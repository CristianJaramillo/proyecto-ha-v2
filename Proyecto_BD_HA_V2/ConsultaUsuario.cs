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
    public partial class ConsultaUsuario : MetroForm
    {

        private Form parent;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public ConsultaUsuario(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchMetroButton_Click(object sender, EventArgs e)
        {
            var userId = 0;

            if (int.TryParse(SearchUserMetroTextBox.Text, out userId))
            {
                var cmd = Connection.GetCommand(string.Format("SELECT * FROM responsable WHERE idResponsable={0}", userId));
                var reader = cmd.ExecuteReader();

                UsersMetroGrid.Rows.Clear();

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
                else
                {
                    MetroMessageBox.Show(this, string.Format("El ID \"{0}\" no existe!", userId), Text + " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
                Connection.Close();
            }
            else
            {
                SearchUserMetroTextBox.Clear();
                MetroMessageBox.Show(this, "El ID no es valido!", Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
