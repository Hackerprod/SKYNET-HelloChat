partial class frmTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplate));
            this.acceptBtn = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Separator = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.acepctBtn = new FlatButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Encabezado = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBox = new System.Windows.Forms.Panel();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CloseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptBtn
            // 
            this.acceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptBtn.Location = new System.Drawing.Point(485, 375);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 16;
            this.acceptBtn.Text = "button1";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(483, 145);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(18, 23);
            this.ok.TabIndex = 24;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Separator);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.acepctBtn);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 409);
            this.panel1.TabIndex = 25;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Event_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Event_MouseUp);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.Separator.Location = new System.Drawing.Point(0, 368);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(632, 1);
            this.Separator.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 302);
            this.panel3.TabIndex = 28;
            // 
            // acepctBtn
            // 
            this.acepctBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(141)))), ((int)(((byte)(230)))));
            this.acepctBtn.BackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.acepctBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acepctBtn.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.acepctBtn.ForeColor = System.Drawing.Color.White;
            this.acepctBtn.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.acepctBtn.ImageAlignment = FlatButton._ImgAlign.Left;
            this.acepctBtn.ImageIcon = null;
            this.acepctBtn.Location = new System.Drawing.Point(543, 374);
            this.acepctBtn.Name = "acepctBtn";
            this.acepctBtn.Rounded = false;
            this.acepctBtn.Size = new System.Drawing.Size(81, 24);
            this.acepctBtn.Style = FlatButton._Style.TextOnly;
            this.acepctBtn.TabIndex = 27;
            this.acepctBtn.Text = "Aceptar";
            this.acepctBtn.Click += new System.EventHandler(this.acepctBtn_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.panel15.Controls.Add(this.Encabezado);
            this.panel15.Controls.Add(this.Cancel);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.panel15.Location = new System.Drawing.Point(0, 29);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(632, 37);
            this.panel15.TabIndex = 25;
            // 
            // Encabezado
            // 
            this.Encabezado.AutoSize = true;
            this.Encabezado.ForeColor = System.Drawing.Color.White;
            this.Encabezado.Location = new System.Drawing.Point(9, 10);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(161, 16);
            this.Encabezado.TabIndex = 27;
            this.Encabezado.Text = "Plantilla para nuevas pruebas";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(484, 90);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(16, 23);
            this.Cancel.TabIndex = 25;
            this.Cancel.Text = "cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(141)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.CloseBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 29);
            this.panel2.TabIndex = 24;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Event_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Event_MouseUp);
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(141)))), ((int)(((byte)(230)))));
            this.CloseBox.Controls.Add(this.ClosePic);
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.Location = new System.Drawing.Point(598, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(34, 29);
            this.CloseBox.TabIndex = 12;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            this.CloseBox.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.CloseBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // ClosePic
            // 
            this.ClosePic.Image = global::SKYNET.Properties.Resources.close11;
            this.ClosePic.Location = new System.Drawing.Point(13, 9);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(13, 12);
            this.ClosePic.TabIndex = 4;
            this.ClosePic.TabStop = false;
            this.ClosePic.Click += new System.EventHandler(this.CloseBox_Click);
            this.ClosePic.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.ClosePic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(141)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.acceptBtn);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTemplate";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Activated += new System.EventHandler(this.frmMessage_Activated);
            this.Deactivate += new System.EventHandler(this.frmMessage_Deactivate);
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.CloseBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button acceptBtn;
    private System.Windows.Forms.Button ok;
    private System.Windows.Forms.Panel panel1;
    private FlatButton acepctBtn;
    private System.Windows.Forms.Panel panel15;
    private System.Windows.Forms.Button Cancel;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label Encabezado;
    private System.Windows.Forms.Panel Separator;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel CloseBox;
    private System.Windows.Forms.PictureBox ClosePic;
}
