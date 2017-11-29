using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_HA_V2.core
{
    public class ParentForm : Form
    {
        protected Form parent;

        public ParentForm(Form parent)
        {
            this.parent = parent;
        }

        public void ParentFormClosed()
        {

        }

    }
}
