using MetroFramework.Forms;
using Proyecto_BD_HA_V2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_BD_HA_V2
{
    public partial class Alta_Productos : MetroForm
    {

        private Form parent;
        private string userId;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="userId"></param>
        public Alta_Productos(Form parent, string userId)
        {
            InitializeComponent();
            this.parent = parent;
            this.userId = userId;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            msj_alta_completo msjalta = new msj_alta_completo();
            msj_alta_error msjerror = new msj_alta_error();
            Producto pProducto = new Producto();
            bool[] numerico = new bool[] {true,true}; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumericoFloat(textoPrecio.Text.Trim());
            numerico[1] = Numerico.EsNumerico(textoStock.Text.Trim());

            if (textoPrecio.Text.Trim() != "" && textoNombre.Text.Trim() != "" && textoStock.Text.Trim() != "" && comboTalla.Text.Trim() != "")
            {
                if(numerico[0] == true && numerico[1] == true)
                {
                    pProducto.idResponsable = userId;
                    pProducto.Nombre = textoNombre.Text.Trim();
                    pProducto.Talla = comboTalla.Text.Trim();
                    pProducto.Precio = textoPrecio.Text.Trim();
                    pProducto.Stock = textoStock.Text.Trim();
                    int resultado = TablaProducto.AgregarProducto(pProducto);

                    if (resultado > 0)
                    {
                        msjalta.Visible = true;
                        Hide();
                    }
                    else
                    {
                        msjerror.Visible = true;
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("El campo de texto con asterisco, Deben de ser numeros enteros");
                }
            }
            else
            {
                MessageBox.Show("Debe de rellenar los campos con asterisco");
            }

        }

        private void textoCosto_Validated(object sender, EventArgs e)
        {
            if (!Numerico.EsNumerico(textoStock.Text))
            {
                error.SetError(textoStock, "debe ingresar un numero");
//                textoProducto.Focus(); // Para restringir al usuario que ingrese un numero
            }
            else
            {
                error.Clear();
            }
        }

        private void textoPrecio_Validated(object sender, EventArgs e)
        {
            if (!Numerico.EsNumericoFloat(textoPrecio.Text))
            {
                error.SetError(textoPrecio, "debe ingresar un numero flotante");
                //                textoProducto.Focus(); // Para restringir al usuario que ingrese un numero
            }
            else
            {
                error.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alta_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
