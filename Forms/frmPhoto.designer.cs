using SKYNET.Properties;
using System.ComponentModel;
using System.Windows.Forms;

namespace SKYNET.Common
{
    partial class frmPhoto
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhoto));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlTitlebar = new System.Windows.Forms.Panel();
            this.Tittle = new System.Windows.Forms.Label();
            this.panelClose = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TicToc = new System.Windows.Forms.Timer(this.components);
            this.pnlCancelar = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pnlAceptar = new System.Windows.Forms.Panel();
            this.lblAceptar = new System.Windows.Forms.Label();
            this.pnlPhotocenter = new System.Windows.Forms.Panel();
            this.pnlPhotoleft = new System.Windows.Forms.Panel();
            this.pnlPhoto = new System.Windows.Forms.Panel();
            this.lblResize = new System.Windows.Forms.Label();
            this.lblSelector = new System.Windows.Forms.Label();
            this.picSelectPhoto = new System.Windows.Forms.PictureBox();
            this.pnlPhotoright = new System.Windows.Forms.Panel();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.lblPreView = new System.Windows.Forms.Label();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.CursorWorker = new System.ComponentModel.BackgroundWorker();
            this.pnlTitlebar.SuspendLayout();
            this.panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.pnlCancelar.SuspendLayout();
            this.pnlAceptar.SuspendLayout();
            this.pnlPhotocenter.SuspendLayout();
            this.pnlPhotoleft.SuspendLayout();
            this.pnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectPhoto)).BeginInit();
            this.pnlPhotoright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(572, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 24);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(542, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 24);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(514, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 24);
            this.panel5.TabIndex = 1;
            // 
            // pnlTitlebar
            // 
            this.pnlTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.pnlTitlebar.Controls.Add(this.Tittle);
            this.pnlTitlebar.Controls.Add(this.panelClose);
            this.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitlebar.Name = "pnlTitlebar";
            this.pnlTitlebar.Size = new System.Drawing.Size(660, 25);
            this.pnlTitlebar.TabIndex = 0;
            this.pnlTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseDown);
            this.pnlTitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseMove);
            this.pnlTitlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseUp);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.ForeColor = System.Drawing.Color.White;
            this.Tittle.Location = new System.Drawing.Point(3, 1);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(111, 21);
            this.Tittle.TabIndex = 10;
            this.Tittle.Text = "RevLauncher";
            this.Tittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseDown);
            this.Tittle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseMove);
            this.Tittle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseUp);
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.panelClose.Controls.Add(this.closeBtn);
            this.panelClose.Location = new System.Drawing.Point(610, -4);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(45, 30);
            this.panelClose.TabIndex = 8;
            this.panelClose.Click += new System.EventHandler(this.PanelClose_Click);
            this.panelClose.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            this.panelClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseMove);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = Resources.close11;
            this.closeBtn.Location = new System.Drawing.Point(16, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(13, 12);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.PanelClose_Click);
            this.closeBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            this.closeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseMove);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(28, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(24, 24);
            this.panel10.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(200, 78);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 78);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TicToc
            // 
            this.TicToc.Enabled = true;
            // 
            // pnlCancelar
            // 
            this.pnlCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.pnlCancelar.Controls.Add(this.lblCancelar);
            this.pnlCancelar.Location = new System.Drawing.Point(141, 390);
            this.pnlCancelar.Name = "pnlCancelar";
            this.pnlCancelar.Size = new System.Drawing.Size(88, 31);
            this.pnlCancelar.TabIndex = 94;
            this.pnlCancelar.Click += new System.EventHandler(this.BtnCancel);
            this.pnlCancelar.MouseLeave += new System.EventHandler(this.PnlCancelar_MouseLeave);
            this.pnlCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlCancelar_MouseMove);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12.75F);
            this.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.lblCancelar.Location = new System.Drawing.Point(18, 4);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(57, 17);
            this.lblCancelar.TabIndex = 1;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Click += new System.EventHandler(this.BtnCancel);
            this.lblCancelar.MouseLeave += new System.EventHandler(this.PnlCancelar_MouseLeave);
            this.lblCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlCancelar_MouseMove);
            // 
            // pnlAceptar
            // 
            this.pnlAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.pnlAceptar.Controls.Add(this.lblAceptar);
            this.pnlAceptar.Location = new System.Drawing.Point(47, 390);
            this.pnlAceptar.Name = "pnlAceptar";
            this.pnlAceptar.Size = new System.Drawing.Size(88, 31);
            this.pnlAceptar.TabIndex = 93;
            this.pnlAceptar.Click += new System.EventHandler(this.LblOkPhoto_Click);
            this.pnlAceptar.MouseLeave += new System.EventHandler(this.LblAceptar_MouseLeave);
            this.pnlAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblAceptar_MouseMove);
            // 
            // lblAceptar
            // 
            this.lblAceptar.AutoSize = true;
            this.lblAceptar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12.75F);
            this.lblAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.lblAceptar.Location = new System.Drawing.Point(19, 4);
            this.lblAceptar.Name = "lblAceptar";
            this.lblAceptar.Size = new System.Drawing.Size(49, 17);
            this.lblAceptar.TabIndex = 0;
            this.lblAceptar.Text = "Aceptar";
            this.lblAceptar.Click += new System.EventHandler(this.LblOkPhoto_Click);
            this.lblAceptar.MouseLeave += new System.EventHandler(this.LblAceptar_MouseLeave);
            this.lblAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblAceptar_MouseMove);
            // 
            // pnlPhotocenter
            // 
            this.pnlPhotocenter.Controls.Add(this.pnlPhotoleft);
            this.pnlPhotocenter.Controls.Add(this.pnlPhotoright);
            this.pnlPhotocenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhotocenter.Location = new System.Drawing.Point(0, 25);
            this.pnlPhotocenter.Name = "pnlPhotocenter";
            this.pnlPhotocenter.Size = new System.Drawing.Size(660, 433);
            this.pnlPhotocenter.TabIndex = 95;
            // 
            // pnlPhotoleft
            // 
            this.pnlPhotoleft.Controls.Add(this.pnlPhoto);
            this.pnlPhotoleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhotoleft.Location = new System.Drawing.Point(0, 0);
            this.pnlPhotoleft.Name = "pnlPhotoleft";
            this.pnlPhotoleft.Size = new System.Drawing.Size(423, 433);
            this.pnlPhotoleft.TabIndex = 4;
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.pnlPhoto.Controls.Add(this.lblResize);
            this.pnlPhoto.Controls.Add(this.lblSelector);
            this.pnlPhoto.Controls.Add(this.picSelectPhoto);
            this.pnlPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhoto.Location = new System.Drawing.Point(0, 0);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(423, 433);
            this.pnlPhoto.TabIndex = 3;
            this.pnlPhoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseDown);
            this.pnlPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseMove);
            this.pnlPhoto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseUp);
            // 
            // lblResize
            // 
            this.lblResize.AllowDrop = true;
            this.lblResize.BackColor = System.Drawing.Color.White;
            this.lblResize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResize.Location = new System.Drawing.Point(186, 176);
            this.lblResize.Name = "lblResize";
            this.lblResize.Size = new System.Drawing.Size(9, 9);
            this.lblResize.TabIndex = 7;
            // 
            // lblSelector
            // 
            this.lblSelector.AllowDrop = true;
            this.lblSelector.BackColor = System.Drawing.Color.Transparent;
            this.lblSelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelector.Location = new System.Drawing.Point(76, 69);
            this.lblSelector.MinimumSize = new System.Drawing.Size(38, 38);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(200, 200);
            this.lblSelector.TabIndex = 5;
            // 
            // picSelectPhoto
            // 
            this.picSelectPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelectPhoto.Location = new System.Drawing.Point(0, 0);
            this.picSelectPhoto.Name = "picSelectPhoto";
            this.picSelectPhoto.Size = new System.Drawing.Size(18, 18);
            this.picSelectPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSelectPhoto.TabIndex = 4;
            this.picSelectPhoto.TabStop = false;
            // 
            // pnlPhotoright
            // 
            this.pnlPhotoright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.pnlPhotoright.Controls.Add(this.TableLayoutPanel1);
            this.pnlPhotoright.Controls.Add(this.picSmall);
            this.pnlPhotoright.Controls.Add(this.pnlCancelar);
            this.pnlPhotoright.Controls.Add(this.pnlAceptar);
            this.pnlPhotoright.Controls.Add(this.lblPreView);
            this.pnlPhotoright.Controls.Add(this.pctPhoto);
            this.pnlPhotoright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPhotoright.Location = new System.Drawing.Point(423, 0);
            this.pnlPhotoright.Name = "pnlPhotoright";
            this.pnlPhotoright.Size = new System.Drawing.Size(237, 433);
            this.pnlPhotoright.TabIndex = 3;
            this.pnlPhotoright.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseDown);
            this.pnlPhotoright.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseMove);
            this.pnlPhotoright.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseUp);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.Location = new System.Drawing.Point(233, 429);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.TableLayoutPanel1.TabIndex = 44;
            // 
            // picSmall
            // 
            this.picSmall.BackColor = System.Drawing.Color.White;
            this.picSmall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSmall.Location = new System.Drawing.Point(20, 246);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(38, 38);
            this.picSmall.TabIndex = 42;
            this.picSmall.TabStop = false;
            this.picSmall.Visible = false;
            // 
            // lblPreView
            // 
            this.lblPreView.AutoSize = true;
            this.lblPreView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.lblPreView.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.lblPreView.Location = new System.Drawing.Point(6, 3);
            this.lblPreView.Name = "lblPreView";
            this.lblPreView.Size = new System.Drawing.Size(68, 16);
            this.lblPreView.TabIndex = 13;
            this.lblPreView.Text = "Vista previa";
            this.lblPreView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pctPhoto
            // 
            this.pctPhoto.BackColor = System.Drawing.Color.White;
            this.pctPhoto.Location = new System.Drawing.Point(9, 21);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(220, 220);
            this.pctPhoto.TabIndex = 12;
            this.pctPhoto.TabStop = false;
            this.pctPhoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseDown);
            this.pctPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseMove);
            this.pctPhoto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tittle_MouseUp);
            // 
            // CursorWorker
            // 
            this.CursorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CursorWorker_DoWork);
            // 
            // frmPhoto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(660, 458);
            this.Controls.Add(this.pnlPhotocenter);
            this.Controls.Add(this.pnlTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(660, 458);
            this.MinimumSize = new System.Drawing.Size(660, 458);
            this.Name = "frmPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainfrm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTitlebar.ResumeLayout(false);
            this.pnlTitlebar.PerformLayout();
            this.panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.pnlCancelar.ResumeLayout(false);
            this.pnlCancelar.PerformLayout();
            this.pnlAceptar.ResumeLayout(false);
            this.pnlAceptar.PerformLayout();
            this.pnlPhotocenter.ResumeLayout(false);
            this.pnlPhotoleft.ResumeLayout(false);
            this.pnlPhoto.ResumeLayout(false);
            this.pnlPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectPhoto)).EndInit();
            this.pnlPhotoright.ResumeLayout(false);
            this.pnlPhotoright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        public Panel panel3;
        public Panel panel4;
        public Panel panel5;
        public Panel panel10;
        public Panel pnlTitlebar;
        public TabPage tabPage1;
        public TabPage tabPage2;
        private IContainer components;
        private Timer TicToc;
        private Panel pnlCancelar;
        private Label lblCancelar;
        private Panel pnlAceptar;
        private Label lblAceptar;
        private Panel pnlPhotocenter;
        private Panel pnlPhotoleft;
        public Panel pnlPhoto;
        private Label lblResize;
        private Label lblSelector;
        public PictureBox picSelectPhoto;
        public Panel pnlPhotoright;
        private TableLayoutPanel TableLayoutPanel1;
        private PictureBox picSmall;
        private Label lblPreView;
        private PictureBox pctPhoto;
        private Label Tittle;
        private Panel panelClose;
        private PictureBox closeBtn;
        private BackgroundWorker CursorWorker;
    }
}