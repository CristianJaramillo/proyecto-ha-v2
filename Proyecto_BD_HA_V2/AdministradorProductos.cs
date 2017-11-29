using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_HA_V2
{
    public partial class AdministradorProductos : MetroForm
    {

        #region
        private Form parent;
        private Form children;
        private string userId;
        #endregion

        public AdministradorProductos(Form parent, string userId)
        {
            InitializeComponent();
            this.parent = parent;
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alta_Productos altaprod = new Alta_Productos();
            altaprod.Recibir(userId);
            altaprod.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baja baja = new Baja();
            baja.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cambio_datos cambio = new Cambio_datos();
            cambio.Recibir(userId);
            cambio.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdministradorProductos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdministradorProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
