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
    public partial class AdministradorClientes : MetroForm
    {

#region
        private Form parent;
        private Form children;
#endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public AdministradorClientes(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClientMetroTile_Click(object sender, EventArgs e)
        {
            children = new AltaClientes();
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteClientMetroTile_Click(object sender, EventArgs e)
        {
            children = new BajaCliente();
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchClientMetroTile_Click(object sender, EventArgs e)
        {
            children = new ConsultaCliente();
            children.Show();
            Hide();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateClientMetroTile_Click(object sender, EventArgs e)
        {
            children = new CambioCliente();
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdministradorClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
