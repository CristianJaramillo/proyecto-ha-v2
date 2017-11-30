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
    public partial class BDResponsable : MetroForm
    {

        private Form parent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public BDResponsable(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDResponsable_Load(object sender, EventArgs e)
        {
            var cmd = Connection.GetCommand("SELECT * FROM responsable");
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UsersMetroGrid.Rows.Add(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(7),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6)
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
        private void BDResponsable_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void UsersMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
