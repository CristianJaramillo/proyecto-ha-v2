using MetroFramework;
using MetroFramework.Forms;
using Proyecto_BD_HA_V2.Model;
using Proyecto_BD_HA_V2.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_HA_V2
{
    public partial class SalesForm : MetroForm
    {

        private Form parent;
        private string userId;

        private static string show_client_id = "SELECT idCliente FROM cliente";
        private static string show_product_id = "SELECT idproducto FROM productos";
        private string insert_factura = "INSERT INTO factura (Cliente_idCliente, Responsable_idResponsable, Fecha) VALUES ({0}, {1}, CURRENT_TIMESTAMP()); SELECT LAST_INSERT_ID();";
        private static string find_client_by_id = "SELECT * FROM cliente WHERE idCliente='{0}' LIMIT 1";
        private static string find_product_by_id = "SELECT * FROM productos WHERE idProducto='{0}' LIMIT 1";

        private string clientID;
        private string clientName;
        private string productID;
        private int productCount;
        private int stock;
        private Producto producto;
        private double total;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="userId"></param>
        public SalesForm(Form parent, string userId)
        {
            InitializeComponent();
            this.parent = parent;
            this.userId = userId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesForm_Load(object sender, EventArgs e)
        {
            var cmd = Connection.GetMysqlCommand(show_client_id);
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ClientIDMetroComboBox.Items.Add(string.Format("{0}", reader.GetInt32(0)));
                }
            }

            Connection.Close();

            cmd = Connection.GetMysqlCommand(show_product_id);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProductIDMetroComboBox.Items.Add(string.Format("{0}", reader.GetInt32(0)));
                }
            }

            Connection.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectUserMetroButton_Click(object sender, EventArgs e)
        {
            if (!IsValidClientID()) return;

            var cmd = Connection.GetMysqlCommand(string.Format(find_client_by_id, clientID));
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ClientNameMetroTextBox.Text = string.Format("{0} {1}", reader.GetString(1), reader.GetString(2));
                }
            }

            Connection.Close();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidClientID()
        {
            clientID = ClientIDMetroComboBox.Text.Trim();

            if (string.IsNullOrEmpty(clientID))
            {
                ClientIDErrorMetroLabel.Text = "El campo \"Cliente ID\" es requerido";
                ClientIDErrorMetroLabel.Visible = true;
            }
            else
            {
                ClientIDErrorMetroLabel.Visible = false;
            }

            return !ClientIDErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidClienName()
        {
            clientName = ClientNameMetroTextBox.Text.Trim();

            if (string.IsNullOrEmpty(clientName))
            {
                ClientNameErrorMetroLabel.Text = "El campo \"Nombre de cliente\" es requerido";
                ClientNameErrorMetroLabel.Visible = true;
            }
            else
            {
                ClientNameErrorMetroLabel.Visible = false;
            }

            return !ClientNameErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductMetroButton_Click(object sender, EventArgs e)
        {
            if (!IsValidProductID()) return;
            if (!IsValidProductCount()) return;

            int row = SearchId(Convert.ToInt32(productID));

            if (row != -1)
            {
                int newProductCount = Convert.ToInt32(SaleMetroGrid.Rows[row].Cells[4].Value) + productCount;
                if (newProductCount <= stock)
                    SaleMetroGrid.Rows[row].Cells[4].Value = newProductCount;
                else
                    MetroMessageBox.Show(this, "No existen suficientes productos!", Text + " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaleMetroGrid.Rows.Add(producto.idProductos, producto.Nombre, producto.Talla, producto.Precio, productCount);
            }

            UpdateMontoVenta();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidProductID()
        {
            productID = ProductIDMetroComboBox.Text.Trim();

            if (string.IsNullOrEmpty(productID))
            {
                ProductIDErrorMetroLabel.Text = "El campo \"Producto ID\" es requerido";
                ProductIDErrorMetroLabel.Visible = true;
            }
            else
            {
                ProductIDErrorMetroLabel.Visible = false;
            }

            return !ProductIDErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidProductCount()
        {
            productCount = 0;

            if (int.TryParse(ProductCountMetroTextBox.Text, out productCount))
            {
                var cmd = Connection.GetMysqlCommand(string.Format(find_product_by_id, productID));
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        stock = reader.GetInt32(5);

                        if (productCount > stock)
                        {
                            ProductCountErrorMetroLabel.Text = string.Format("Solo existen \"{0}\" unidades en inventario", stock);
                            ProductCountErrorMetroLabel.Visible = true;
                        }
                        else
                        {
                            ProductCountErrorMetroLabel.Visible = false;
                            producto = new Producto();
                            producto.idProductos = reader.GetInt32(0);
                            producto.idResponsable = reader.GetString(1);
                            producto.Nombre = reader.GetString(2);
                            producto.Talla = reader.GetString(3);
                            producto.Precio = reader.GetString(4);
                            producto.Stock = reader.GetString(5);
                            producto.FechaIngreso = reader.GetString(6);
                            producto.HoraIngreso = reader.GetString(7);
                        }

                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El producto selecionado no existe!", Text + "- Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ProductIDMetroComboBox.Text = ProductCountMetroTextBox.Text = string.Empty;
                }

                Connection.Close();
            }
            else
            {
                ProductCountErrorMetroLabel.Text = "El campo \"Número de Unidades\" no es valido";
                ProductCountErrorMetroLabel.Visible = true;
            }

            return !ProductCountErrorMetroLabel.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int SearchId(int id)
        {
            int row = -1;

            for (int i = 0; i < SaleMetroGrid.Rows.Count; i++)
            {
                if (Convert.ToInt32(SaleMetroGrid.Rows[i].Cells[0].Value) == id)
                {
                    row = i;
                    break;
                }

            }

            return row;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateMontoVenta()
        {
            total = 0;

            for (int i = 0; i < SaleMetroGrid.Rows.Count; i++)
            {
                total += (Convert.ToDouble(SaleMetroGrid.Rows[i].Cells[3].Value) * Convert.ToInt32(SaleMetroGrid.Rows[i].Cells[4].Value));
            }

            VentaMetroLabel.Text = total.ToString("C", new CultureInfo("en-us"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishSaleMetroButton_Click(object sender, EventArgs e)
        {
            if (!IsValidClientID()) return;
            if (!IsValidClienName()) return;
            if (!IsValidProductID()) return;
            if (!IsValidProductCount()) return;
            if (IsEmptyGrid())
            {
                MetroMessageBox.Show(this, "Por favor agrege productos a su compra!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Creamos una nueva factura
            var cmd = Connection.GetMysqlCommand(string.Format(insert_factura, clientID, userId));
            var reader = cmd.ExecuteReader();
            int idBill = -1;

            if (reader.HasRows)
            {
                while (reader.Read())
                    idBill = reader.GetInt32(0);
            }

            reader.Close();
            
            Connection.Close();

            if (idBill != -1)
            {
                cmd = Connection.GetMysqlCommand(GenerateVenta(idBill));
                reader = cmd.ExecuteReader();
                Connection.Close();

                ProductIDMetroComboBox.Text = ProductCountMetroTextBox.Text = string.Empty;
                ClientIDMetroComboBox.Text = ClientNameMetroTextBox.Text = string.Empty;
                SaleMetroGrid.Rows.Clear();
                UpdateMontoVenta();
                MetroMessageBox.Show(this, "Su compra ha sido un exito!", Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsEmptyGrid()
        {
            return SaleMetroGrid.Rows.Count == 0 || SaleMetroGrid.Rows.Count == 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private string GenerateVenta(int id)
        {
            var insert_register_ventas = "INSERT INTO detalle (Factura_idFactura, Productos_idProducto, Cantidad) VALUES ";

            var update_productos = "UPDATE productos SET Stock=Stock - {0} WHERE idProducto={1};";
            var updates = "";

            for (int i = 0; i < SaleMetroGrid.Rows.Count - 1; i++)
            {
                insert_register_ventas += String.Format("({0}, {1}, {2})", id, SaleMetroGrid.Rows[i].Cells[0].Value, SaleMetroGrid.Rows[i].Cells[4].Value);
                updates += string.Format(update_productos, SaleMetroGrid.Rows[i].Cells[4].Value, SaleMetroGrid.Rows[i].Cells[0].Value);
                if ((i + 1) < SaleMetroGrid.Rows.Count - 1)
                    insert_register_ventas += ", ";
            }

            return insert_register_ventas + ";" + updates;

        }

    }
}
