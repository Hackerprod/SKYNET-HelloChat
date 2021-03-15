using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNET
{
    public partial class SearchTextBox : UserControl
    {
        public Color BorderColor { get; set; }
        public SearchTextBox()
        {
            InitializeComponent();
        }
        private void TexBox_TextChanged(object sender, EventArgs e)
        {
            textBox.ForeColor = ForeColor;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                ClearBox.Visible = false;
                lblSearch.Visible = true;
            }
            else
            {
                ClearBox.Visible = true;
                lblSearch.Visible = false;
            }
            Text = textBox.Text;
            base.OnTextChanged(e);
        }

        private void ClearBox_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            lblSearch.Visible = true;
        }

        private void TexBox_Enter(object sender, EventArgs e)
        {
            //BackColor = Color.FromArgb(84, 195, 243);
            ChangeColors(true);
        }

        private void ChangeColors(bool v)
        {
            if (v)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    //Controls[i].BackColor = Color.White;
                }
                //textBox.BackColor = Color.White;
            }
            else
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].BackColor = BackColor;
                }
                textBox.BackColor = BackColor;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            //BackColor = Color.FromArgb(241, 241, 241);
            ChangeColors(false);
        }

        private void LblSearch_Click(object sender, EventArgs e)
        {
            textBox.Focus();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void SearchTextBox_Load(object sender, EventArgs e)
        {
            lblSearch.BackColor = this.BackColor;
            textBox.BackColor = this.BackColor;
            panel1.BackColor = this.BackColor;
            panel2.BackColor = this.BackColor;
            panel3.BackColor = this.BackColor;
            panel4.BackColor = this.BackColor;
            panel5.BackColor = this.BackColor;
            panel6.BackColor = this.BackColor;
        }
    }
}
