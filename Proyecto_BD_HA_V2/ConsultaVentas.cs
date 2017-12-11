using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Proyecto_BD_HA_V2.Store;
using MetroFramework;
using System.Globalization;

namespace Proyecto_BD_HA_V2
{
    public partial class ConsultaVentas : MetroForm
    {

        #region
        private Form parent;
        private string userId;
        #endregion

        private static string SEARCH_BILL_DETAILS = "SELECT * FROM detalle, productos WHERE detalle.Factura_idFactura={0} AND productos.idProducto=detalle.Productos_idProducto;";
        private int BillID;

        /// <summary>
        /// 
        /// </summary>
        public ConsultaVentas(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultaVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchMetroButton_Click(object sender, EventArgs e)
        {
            if (!IsValidBillID()) return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValidBillID()
        {

            var searchID = SearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchID))
            {
                BillErrorMetroLabel.Text = "El campo \"Factura ID\" es requerido";
                BillErrorMetroLabel.Visible = true;
            }
            else if (int.TryParse(searchID, out BillID))
            {

                BillMetroGrid.Rows.Clear();

                var cmd = Connection.GetCommand(string.Format(SEARCH_BILL_DETAILS, BillID));
                var reader = cmd.ExecuteReader();

                var total = 0.00;

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        BillMetroGrid.Rows.Add(
                                reader.GetInt32(1),
                                reader.GetString(6),
                                reader.GetInt32(3),
                                reader.GetInt32(8),
                                reader.GetString(7)
                            );

                        total += (reader.GetInt32(3) * reader.GetInt32(8));
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "No existe información de la factura!", this.Text + "- Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                Connection.Close();
                TotalVentaMetroLabel.Text = total.ToString("C", new CultureInfo("en-us"));
                SearchTextBox.Clear();
                BillErrorMetroLabel.Visible = false;

            }
            else
            {
                BillErrorMetroLabel.Text = "El campo \"Factura ID\" no es valido";
                BillErrorMetroLabel.Visible = true;
            }

            return !BillErrorMetroLabel.Visible;
        }

    }
}
