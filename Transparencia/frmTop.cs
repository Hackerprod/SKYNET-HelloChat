using SKYNET;
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
    public partial class frmTop : Form
    {
        public static frmTop frm;

        public frmTop()
        {
            InitializeComponent();
            frm = this;
            new frmBack() { Location = this.Location, Size = this.Size }.Show();

        }

        private void FrmTop_Move(object sender, EventArgs e)
        {
            frmBack.frm.Location = Location;
            Activate();
        }

        private void FrmTop_Load(object sender, EventArgs e)
        {
            int maximum = 100;
            string opacity = frmBack.frm.Opacity.ToString();
            opacity = opacity.Replace("0,", "").Replace("0.", "");

            int value = Convert.ToInt32(opacity);
            if (value == 1) value = 100;

            trackBar1.Maximum = maximum;
            trackBar1.Value = value;

            //new Form1().ShowDialog();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            double value = trackBar1.Value;
            //

            if (value < 100)
            {
                value = value / 100;
            }
            frmBack.frm.Opacity = value;
            Text = (value.ToString());
        }

        private void FrmTop_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmBack.frm.Close();
            modCommon.Close(this);
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            //pictureBox1.BackColor = Color.FromArgb(trackBar2.Value, Color.Red);
            panel1.BackColor = Color.FromArgb(trackBar2.Value, Color.Black);

            label1.Text = trackBar2.Value.ToString();
        }
    }
}
