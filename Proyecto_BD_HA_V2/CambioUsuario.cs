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
    public partial class CambioUsuario : MetroForm
    {

        private Form parent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public CambioUsuario(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambioUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
