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
    public partial class MenuVendedor : MetroForm
    {

#region
        private Form parent;
        private string userId;
#endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public MenuVendedor(Form parent, string userId)
        {
            InitializeComponent();
            this.parent = parent;
            this.userId = userId;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SignIn ini = new SignIn();
            if (MessageBox.Show("¿Esta Seguro que desea cerrar Sesión?", "¿Estas Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ini.Visible = true;
                Hide();
                MessageBox.Show("Buen dia");

            }
            else
                MessageBox.Show("Se cancelo la solicitud", "Solicitud Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventas ve = new Ventas(this, userId);
            ve.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaVentas ve = new ConsultaVentas(this);
            ve.Show();
        }
    }
}
