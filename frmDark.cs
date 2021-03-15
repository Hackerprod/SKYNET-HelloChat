using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNET
{
    public partial class frmDark : Form
    {
        private bool mouseDown;     //Mover ventana
        private Point lastLocation; //Mover ventana
        public static frmDark frm;

        public frmDark()
        {
            InitializeComponent();
            frm = this;
            modCommon.Show(getSteamId("Hackerprod"));
        }
        private string getSteamId(string user)
        {
            string num = "76";
            num += new Random().Next(99999999);
            num += new Random().Next(9999999);
            return num.ToString();
        }
        private void FrmDark_Load(object sender, EventArgs e)
        {
            SetAllMouseMove(this);
        }

        private void SetAllMouseMove(Control control)
        {
            control.MouseMove += Event_MouseMove;
            control.MouseDown += Event_MouseDown;
            control.MouseUp += Event_MouseUp;

        }
        private void Event_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
                Opacity = 0.93;
            }
        }


        private void Event_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void Event_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            Opacity = 100;
        }
    }
}
