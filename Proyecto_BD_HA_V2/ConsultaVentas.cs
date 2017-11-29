using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // Nuevo
using MySql.Data.MySqlClient;
using System.Xml;
using System.Xml.Serialization;
using MetroFramework.Forms;

namespace Proyecto_BD_HA_V2
{
    public partial class ConsultaVentas : MetroForm
    {

        #region
        private Form parent;
        private Form childre;
        private string userId;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public ConsultaVentas(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool[] numerico = new bool[] { true }; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumerico(textBox1.Text.Trim());

            if (textBox1.Text.Trim() != "")
            {
                if (numerico[0] == true)
                {
                    dataGridViewBuscar.DataSource = TablaVentas.Buscar(textBox1.Text);
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

        DataTable dtDatos = new DataTable();
        DataSet dtSet = new DataSet();
        

        private void btnXML_Click(object sender, EventArgs e)
        {
            ControlReporte re = new ControlReporte(textBox1.Text.Trim());
            re.Show();
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
    }
}
