namespace SKYNET
{
    partial class frmLog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChat.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChat.Location = new System.Drawing.Point(0, 0);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(800, 450);
            this.txtChat.TabIndex = 0;
            this.txtChat.Text = "";
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLog";
            this.Text = "frmLog";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtChat;
    }
}