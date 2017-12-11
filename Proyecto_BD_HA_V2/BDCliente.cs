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
using Proyecto_BD_HA_V2.Store;

namespace Proyecto_BD_HA_V2
{
    public partial class BDCliente : MetroForm
    {

        private Form parent;

        /// <summary>
        /// 
        /// </summary>
        public BDCliente(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDCliente_Load(object sender, EventArgs e)
        {
            var cmd = Connection.GetCommand("SELECT * FROM cliente");
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ClientsMetroGrid.Rows.Add(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5)
                    );
                }
            }

            reader.Close();
            Connection.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
