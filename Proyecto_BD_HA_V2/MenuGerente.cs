using MetroFramework;
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
    public partial class MenuGerente : MetroForm
    {

#region
        private Form parent;
        private Form children;
        private string userId;
#endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public MenuGerente(Form parent, string userId)
        {
            InitializeComponent();
            this.parent = parent;
            this.userId = userId;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuGerente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialodresult = MetroMessageBox.Show(this, "¿Esta Seguro que desea cerrar Sesión?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialodresult == DialogResult.Yes)
            {
                parent.Show();
            }

            e.Cancel = (dialodresult == DialogResult.No);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersButton_Click(object sender, EventArgs e)
        {
            children = new AdministradorUsuario(this);
            children.Show();
            Hide();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientsButton_Click(object sender, EventArgs e)
        {
            children = new AdministradorClientes(this);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsButton_Click(object sender, EventArgs e)
        {
            children = new AdministradorProductos(this, userId);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesButton_Click(object sender, EventArgs e)
        {
            children = new SalesForm(this, userId);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportSalesButton_Click(object sender, EventArgs e)
        {
            children = new ConsultaVentas(this);
            children.Show();
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            children = new Pantalla_Enviar(this);
            children.Show();
            Hide();
        }
    }
}
