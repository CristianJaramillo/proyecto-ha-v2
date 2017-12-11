using MetroFramework.Forms;
using Proyecto_BD_HA_V2.Model;
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
    public partial class Cambio_datos : MetroForm
    {
        private Form parent;
        private string userId;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="userID"></param>
        public Cambio_datos(Form parent, string userId)
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
        private void Cambio_datos_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
