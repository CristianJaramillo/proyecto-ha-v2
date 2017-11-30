using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Proyecto_BD_HA_V2
{
    public partial class AdministradorUsuario : MetroForm
    {

# region
        /// <summary>
        /// 
        /// </summary>
        private Form parent;
        /// <summary>
        /// 
        /// </summary>
        private Form children;
#endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public AdministradorUsuario(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createMetroTile_Click(object sender, EventArgs e)
        {
            children = new AltaUsuario(this);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateMetroTile_Click(object sender, EventArgs e)
        {
            children = new CambioUsuario(this);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteMetroTile_Click(object sender, EventArgs e)
        {
            children = new BajaUsuario(this);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowUsersMetroTile_Click(object sender, EventArgs e)
        {
            children = new BDResponsable(this);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchMetroTile_Click(object sender, EventArgs e)
        {
            children = new ConsultaUsuario(this);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdministradorUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
