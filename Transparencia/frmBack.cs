using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparencia
{
    public partial class frmBack : Form
    {
        public static frmBack frm;
        public frmBack()
        {
            InitializeComponent();
            frm = this;

        }

        private void FrmBack_Load(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
