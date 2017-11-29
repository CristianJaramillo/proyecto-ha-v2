using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para el manejo consultado SQL
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // Nuevo
using MySql.Data.MySqlClient;
using System.IO; // Para directory y FileStream
using MetroFramework.Forms;

namespace Proyecto_BD_HA_V2
{
    public partial class BDCliente : MetroForm
    {
        private DataTable dtDatos = new DataTable();

        /// <summary>
        /// 
        /// </summary>
        public BDCliente()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDCliente_Load(object sender, EventArgs e)
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            //            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(string.Format("SELECT `idCliente`, `Nombre`, `Apellidos`, `Direccion`, `Telefono`, `email` FROM `cliente`"), _conexion);
            mdaDatos.Fill(dtDatos);
            dataGridReporte.DataSource = dtDatos;
            _conexion.Close();
        }
    }
}
