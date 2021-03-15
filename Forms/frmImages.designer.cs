partial class frmImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImages));
            this.acceptBtn = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Separator = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.word = new System.Windows.Forms.TextBox();
            this.CreateImage = new FlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LetterIMG = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.screenshot = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.screen = new FlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Searchbtn = new FlatButton();
            this.Redondeado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acepctBtn = new FlatButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Encabezado = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBox = new System.Windows.Forms.Panel();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LetterIMG)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshot)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(651, 615);
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
            this.Separator.Location = new System.Drawing.Point(0, 576);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(651, 1);
            this.Separator.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.word);
            this.panel3.Controls.Add(this.CreateImage);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.screen);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Searchbtn);
            this.panel3.Controls.Add(this.Redondeado);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 510);
            this.panel3.TabIndex = 28;
            // 
            // word
            // 
            this.word.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.word.Cursor = System.Windows.Forms.Cursors.Default;
            this.word.Location = new System.Drawing.Point(139, 138);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(102, 23);
            this.word.TabIndex = 36;
            this.word.Text = "H";
            // 
            // CreateImage
            // 
            this.CreateImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(141)))), ((int)(((byte)(230)))));
            this.CreateImage.BackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.CreateImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateImage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.CreateImage.ForeColor = System.Drawing.Color.White;
            this.CreateImage.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.CreateImage.ImageAlignment = FlatButton._ImgAlign.Left;
            this.CreateImage.ImageIcon = null;
            this.CreateImage.Location = new System.Drawing.Point(139, 164);
            this.CreateImage.Name = "CreateImage";
            this.CreateImage.Rounded = false;
            this.CreateImage.Size = new System.Drawing.Size(102, 24);
            this.CreateImage.Style = FlatButton._Style.TextOnly;
            this.CreateImage.TabIndex = 35;
            this.CreateImage.Text = "Crear Imagen";
            this.CreateImage.Click += new System.EventHandler(this.CreateImage_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.LetterIMG);
            this.panel6.Location = new System.Drawing.Point(139, 32);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(2);
            this.panel6.Size = new System.Drawing.Size(102, 102);
            this.panel6.TabIndex = 34;
            // 
            // LetterIMG
            // 
            this.LetterIMG.BackColor = System.Drawing.Color.White;
            this.LetterIMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LetterIMG.Location = new System.Drawing.Point(2, 2);
            this.LetterIMG.Name = "LetterIMG";
            this.LetterIMG.Size = new System.Drawing.Size(98, 98);
            this.LetterIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LetterIMG.TabIndex = 0;
            this.LetterIMG.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Image from word";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.screenshot);
            this.panel5.Location = new System.Drawing.Point(12, 229);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(408, 239);
            this.panel5.TabIndex = 32;
            // 
            // screenshot
            // 
            this.screenshot.BackColor = System.Drawing.Color.White;
            this.screenshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenshot.Location = new System.Drawing.Point(2, 2);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(404, 235);
            this.screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screenshot.TabIndex = 0;
            this.screenshot.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.Avatar);
            this.panel4.Location = new System.Drawing.Point(12, 32);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(102, 102);
            this.panel4.TabIndex = 31;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.White;
            this.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Avatar.Location = new System.Drawing.Point(2, 2);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(98, 98);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(141)))), ((int)(((byte)(230)))));
            this.screen.BackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.screen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screen.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.screen.ForeColor = System.Drawing.Color.White;
            this.screen.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.screen.ImageAlignment = FlatButton._ImgAlign.Left;
            this.screen.ImageIcon = null;
            this.screen.Location = new System.Drawing.Point(12, 480);
            this.screen.Name = "screen";
            this.screen.Rounded = false;
            this.screen.Size = new System.Drawing.Size(158, 24);
            this.screen.Style = FlatButton._Style.TextOnly;
            this.screen.TabIndex = 30;
            this.screen.Text = "Capturar pantalla";
            this.screen.Click += new System.EventHandler(this.Screen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Captura de pantalla";
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(141)))), ((int)(((byte)(230)))));
            this.Searchbtn.BackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.Searchbtn.ImageAlignment = FlatButton._ImgAlign.Left;
            this.Searchbtn.ImageIcon = null;
            this.Searchbtn.Location = new System.Drawing.Point(12, 164);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Rounded = false;
            this.Searchbtn.Size = new System.Drawing.Size(102, 24);
            this.Searchbtn.Style = FlatButton._Style.TextOnly;
            this.Searchbtn.TabIndex = 28;
            this.Searchbtn.Text = "Seleccionar";
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Redondeado
            // 
            this.Redondeado.AutoSize = true;
            this.Redondeado.Checked = true;
            this.Redondeado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Redondeado.Location = new System.Drawing.Point(12, 138);
            this.Redondeado.Name = "Redondeado";
            this.Redondeado.Size = new System.Drawing.Size(94, 20);
            this.Redondeado.TabIndex = 4;
            this.Redondeado.Text = "Redondeado";
            this.Redondeado.UseVisualStyleBackColor = true;
            this.Redondeado.CheckedChanged += new System.EventHandler(this.Redondeado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar avatar";
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
            this.acepctBtn.Location = new System.Drawing.Point(562, 582);
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
            this.panel15.Size = new System.Drawing.Size(651, 37);
            this.panel15.TabIndex = 25;
            // 
            // Encabezado
            // 
            this.Encabezado.AutoSize = true;
            this.Encabezado.ForeColor = System.Drawing.Color.White;
            this.Encabezado.Location = new System.Drawing.Point(9, 10);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(125, 16);
            this.Encabezado.TabIndex = 27;
            this.Encabezado.Text = "Trabajo con Imágenes";
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
            this.panel2.Size = new System.Drawing.Size(651, 29);
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
            this.CloseBox.Location = new System.Drawing.Point(617, 0);
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
            // frmImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(141)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(653, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.acceptBtn);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmImages";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Activated += new System.EventHandler(this.FrmMessage_Activated);
            this.Deactivate += new System.EventHandler(this.FrmMessage_Deactivate);
            this.Load += new System.EventHandler(this.FrmImages_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LetterIMG)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenshot)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
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
    private System.Windows.Forms.PictureBox Avatar;
    private System.Windows.Forms.Label label1;
    private FlatButton Searchbtn;
    private System.Windows.Forms.CheckBox Redondeado;
    private FlatButton screen;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.PictureBox screenshot;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.TextBox word;
    private FlatButton CreateImage;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.PictureBox LetterIMG;
    private System.Windows.Forms.Label label3;
}
