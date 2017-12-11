using MetroFramework;
using MetroFramework.Forms;
using Proyecto_BD_HA_V2.Store;
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
    public partial class ConsultaCliente : MetroForm
    {

        private Form parent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public ConsultaCliente(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultaCliente_FormClosing(object sender, FormClosingEventArgs e)
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
            var clientId = 0;

            if (int.TryParse(SearchClientMetroTextBox.Text, out clientId))
            {
                var cmd = Connection.GetCommand(string.Format("SELECT * FROM cliente WHERE idCliente={0}", clientId));
                var reader = cmd.ExecuteReader();

                ClientsMetroGrid.Rows.Clear();

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
                else
                {
                    MetroMessageBox.Show(this, string.Format("El ID \"{0}\" no existe!", clientId), Text + " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
                Connection.Close();
            }
            else
            {
                SearchClientMetroTextBox.Clear();
                MetroMessageBox.Show(this, "El ID no es valido!", Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
