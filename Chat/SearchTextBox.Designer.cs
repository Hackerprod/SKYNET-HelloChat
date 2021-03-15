namespace SKYNET
{
    partial class SearchTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ClearBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.ClearBox);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 33);
            this.panel1.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblSearch.Location = new System.Drawing.Point(10, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(46, 17);
            this.lblSearch.TabIndex = 93;
            this.lblSearch.Text = "Buscar";
            this.lblSearch.Click += new System.EventHandler(this.LblSearch_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(9, 5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(178, 18);
            this.textBox.TabIndex = 92;
            this.textBox.TextChanged += new System.EventHandler(this.TexBox_TextChanged);
            this.textBox.Enter += new System.EventHandler(this.TexBox_Enter);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.textBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(187, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 23);
            this.panel6.TabIndex = 6;
            // 
            // ClearBox
            // 
            this.ClearBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearBox.Image = global::SKYNET.Properties.Resources.closegc;
            this.ClearBox.Location = new System.Drawing.Point(197, 5);
            this.ClearBox.Name = "ClearBox";
            this.ClearBox.Size = new System.Drawing.Size(17, 23);
            this.ClearBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ClearBox.TabIndex = 5;
            this.ClearBox.TabStop = false;
            this.ClearBox.Visible = false;
            this.ClearBox.Click += new System.EventHandler(this.ClearBox_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(214, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 23);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(9, 23);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 5);
            this.panel2.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.panel1);
            this.Name = "SearchTextBox";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(220, 37);
            this.Load += new System.EventHandler(this.SearchTextBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox ClearBox;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.TextBox textBox;
    }
}
