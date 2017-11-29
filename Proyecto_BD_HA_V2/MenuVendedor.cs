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

        private Form parent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public MenuVendedor(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
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
        public string num;

        public void Recibir(string usuario_id)
        {
            num = usuario_id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Ventas ve = new Ventas();
            ve.Recibir(num);
            ve.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaVentas ve = new ConsultaVentas();
            ve.Show();
        }
    }
}
