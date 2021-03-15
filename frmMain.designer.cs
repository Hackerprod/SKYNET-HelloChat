using SKYNET;
using SkynetChat;

partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.acceptBtn = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.MinBox = new System.Windows.Forms.Panel();
            this.MinPic = new System.Windows.Forms.PictureBox();
            this.CloseBox = new System.Windows.Forms.Panel();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.Separator = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stcMain = new SkynetChat.SplitContainerEx();
            this.panel10 = new System.Windows.Forms.Panel();
            this.UserContainer = new MetroPanel();
            this.Group_Pannel = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Left_TopPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.searchTextBox1 = new SKYNET.SearchTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.MenuBox = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ChatContainer = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtContainer = new System.Windows.Forms.Panel();
            this.txtMessage = new SKYNET.TXTMessage();
            this.BTN_Emoji = new System.Windows.Forms.PictureBox();
            this.BTN_Send = new System.Windows.Forms.PictureBox();
            this.BTN_Attach = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.Chat_Info = new System.Windows.Forms.Label();
            this.Chat_Tittle = new System.Windows.Forms.Label();
            this.ReloadTimer = new System.Windows.Forms.Timer(this.components);
            this.LobbyGroup = new SKYNET.Controls.UserBox();
            this.panel2.SuspendLayout();
            this.MinBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinPic)).BeginInit();
            this.CloseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stcMain)).BeginInit();
            this.stcMain.Panel1.SuspendLayout();
            this.stcMain.Panel2.SuspendLayout();
            this.stcMain.SuspendLayout();
            this.panel10.SuspendLayout();
            this.Group_Pannel.SuspendLayout();
            this.Left_TopPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.txtContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Emoji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Attach)).BeginInit();
            this.panel11.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.Info);
            this.panel2.Controls.Add(this.MinBox);
            this.panel2.Controls.Add(this.CloseBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 23);
            this.panel2.TabIndex = 24;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Event_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Event_MouseUp);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.ForeColor = System.Drawing.Color.Black;
            this.Info.Location = new System.Drawing.Point(4, 4);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(0, 16);
            this.Info.TabIndex = 14;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.MinBox.Controls.Add(this.MinPic);
            this.MinBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBox.Location = new System.Drawing.Point(765, 0);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(30, 23);
            this.MinBox.TabIndex = 13;
            this.MinBox.Click += new System.EventHandler(this.Minimize_Click);
            this.MinBox.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.MinBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // MinPic
            // 
            this.MinPic.Image = global::SKYNET.Properties.Resources.min_new;
            this.MinPic.Location = new System.Drawing.Point(10, 12);
            this.MinPic.Name = "MinPic";
            this.MinPic.Size = new System.Drawing.Size(13, 12);
            this.MinPic.TabIndex = 4;
            this.MinPic.TabStop = false;
            this.MinPic.Click += new System.EventHandler(this.Minimize_Click);
            this.MinPic.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.MinPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CloseBox.Controls.Add(this.ClosePic);
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.Location = new System.Drawing.Point(795, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(30, 23);
            this.CloseBox.TabIndex = 12;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            this.CloseBox.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.CloseBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // ClosePic
            // 
            this.ClosePic.Image = global::SKYNET.Properties.Resources.close11;
            this.ClosePic.Location = new System.Drawing.Point(9, 6);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(13, 12);
            this.ClosePic.TabIndex = 4;
            this.ClosePic.TabStop = false;
            this.ClosePic.Click += new System.EventHandler(this.CloseBox_Click);
            this.ClosePic.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.ClosePic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Separator.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.Separator.Location = new System.Drawing.Point(0, 23);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(825, 1);
            this.Separator.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.stcMain);
            this.panel1.Controls.Add(this.Separator);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 563);
            this.panel1.TabIndex = 25;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Event_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Event_MouseUp);
            // 
            // stcMain
            // 
            this.stcMain.AllowDrop = true;
            this.stcMain.BackColor = System.Drawing.Color.White;
            this.stcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.stcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.stcMain.Location = new System.Drawing.Point(0, 24);
            this.stcMain.Name = "stcMain";
            // 
            // stcMain.Panel1
            // 
            this.stcMain.Panel1.AllowDrop = true;
            this.stcMain.Panel1.BackColor = System.Drawing.Color.White;
            this.stcMain.Panel1.Controls.Add(this.panel10);
            this.stcMain.Panel1.Controls.Add(this.panel4);
            this.stcMain.Panel1.Controls.Add(this.panel3);
            this.stcMain.Panel1.Controls.Add(this.Left_TopPanel);
            this.stcMain.Panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.stcMain.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stcMain.Panel1MinSize = 100;
            // 
            // stcMain.Panel2
            // 
            this.stcMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(231)))));
            this.stcMain.Panel2.Controls.Add(this.ChatContainer);
            this.stcMain.Panel2.Controls.Add(this.panel13);
            this.stcMain.Panel2.Controls.Add(this.txtContainer);
            this.stcMain.Panel2.Controls.Add(this.panel11);
            this.stcMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stcMain.Panel2MinSize = 170;
            this.stcMain.Size = new System.Drawing.Size(825, 539);
            this.stcMain.SplitterDistance = 260;
            this.stcMain.SplitterWidth = 3;
            this.stcMain.TabIndex = 11;
            this.stcMain.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.UserContainer);
            this.panel10.Controls.Add(this.Group_Pannel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 51);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.panel10.Size = new System.Drawing.Size(260, 477);
            this.panel10.TabIndex = 3;
            // 
            // UserContainer
            // 
            this.UserContainer.AutoScroll = true;
            this.UserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserContainer.HorizontalScrollbar = true;
            this.UserContainer.HorizontalScrollbarBarColor = true;
            this.UserContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.UserContainer.HorizontalScrollbarSize = 10;
            this.UserContainer.Location = new System.Drawing.Point(0, 58);
            this.UserContainer.Name = "UserContainer";
            this.UserContainer.Size = new System.Drawing.Size(260, 417);
            this.UserContainer.TabIndex = 8;
            this.UserContainer.UseSelectable = false;
            this.UserContainer.VerticalScrollbar = true;
            this.UserContainer.VerticalScrollbarBarColor = true;
            this.UserContainer.VerticalScrollbarHighlightOnWheel = false;
            this.UserContainer.VerticalScrollbarSize = 5;
            // 
            // Group_Pannel
            // 
            this.Group_Pannel.BackColor = System.Drawing.Color.White;
            this.Group_Pannel.Controls.Add(this.panel14);
            this.Group_Pannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Group_Pannel.Location = new System.Drawing.Point(0, 2);
            this.Group_Pannel.Name = "Group_Pannel";
            this.Group_Pannel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Group_Pannel.Size = new System.Drawing.Size(260, 56);
            this.Group_Pannel.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 55);
            this.panel14.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 10);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 11);
            this.panel3.TabIndex = 1;
            // 
            // Left_TopPanel
            // 
            this.Left_TopPanel.BackColor = System.Drawing.Color.White;
            this.Left_TopPanel.Controls.Add(this.panel9);
            this.Left_TopPanel.Controls.Add(this.panel8);
            this.Left_TopPanel.Controls.Add(this.MenuBox);
            this.Left_TopPanel.Controls.Add(this.panel7);
            this.Left_TopPanel.Controls.Add(this.panel5);
            this.Left_TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Left_TopPanel.Location = new System.Drawing.Point(0, 8);
            this.Left_TopPanel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Left_TopPanel.Name = "Left_TopPanel";
            this.Left_TopPanel.Size = new System.Drawing.Size(260, 33);
            this.Left_TopPanel.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.searchTextBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(50, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 33);
            this.panel9.TabIndex = 4;
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.searchTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox1.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.searchTextBox1.Size = new System.Drawing.Size(200, 33);
            this.searchTextBox1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(40, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 33);
            this.panel8.TabIndex = 3;
            // 
            // MenuBox
            // 
            this.MenuBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBox.Image = global::SKYNET.Properties.Resources.Menu;
            this.MenuBox.Location = new System.Drawing.Point(10, 0);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(30, 33);
            this.MenuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MenuBox.TabIndex = 2;
            this.MenuBox.TabStop = false;
            this.MenuBox.Click += new System.EventHandler(this.MenuBox_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(250, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 33);
            this.panel7.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 33);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 33);
            this.panel6.TabIndex = 1;
            // 
            // ChatContainer
            // 
            this.ChatContainer.BackColor = System.Drawing.Color.White;
            this.ChatContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatContainer.Location = new System.Drawing.Point(0, 51);
            this.ChatContainer.Name = "ChatContainer";
            this.ChatContainer.Size = new System.Drawing.Size(562, 431);
            this.ChatContainer.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 482);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(562, 12);
            this.panel13.TabIndex = 4;
            // 
            // txtContainer
            // 
            this.txtContainer.BackColor = System.Drawing.Color.White;
            this.txtContainer.Controls.Add(this.txtMessage);
            this.txtContainer.Controls.Add(this.BTN_Emoji);
            this.txtContainer.Controls.Add(this.BTN_Send);
            this.txtContainer.Controls.Add(this.BTN_Attach);
            this.txtContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContainer.Location = new System.Drawing.Point(0, 494);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(562, 45);
            this.txtContainer.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(49, 0);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Padding = new System.Windows.Forms.Padding(2);
            this.txtMessage.Size = new System.Drawing.Size(415, 45);
            this.txtMessage.TabIndex = 9;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMessage_KeyDown);
            // 
            // BTN_Emoji
            // 
            this.BTN_Emoji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Emoji.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Emoji.Image = global::SKYNET.Properties.Resources.em_1;
            this.BTN_Emoji.Location = new System.Drawing.Point(464, 0);
            this.BTN_Emoji.Name = "BTN_Emoji";
            this.BTN_Emoji.Size = new System.Drawing.Size(49, 45);
            this.BTN_Emoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_Emoji.TabIndex = 8;
            this.BTN_Emoji.TabStop = false;
            // 
            // BTN_Send
            // 
            this.BTN_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Send.Image = global::SKYNET.Properties.Resources.send;
            this.BTN_Send.Location = new System.Drawing.Point(513, 0);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(49, 45);
            this.BTN_Send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_Send.TabIndex = 7;
            this.BTN_Send.TabStop = false;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // BTN_Attach
            // 
            this.BTN_Attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Attach.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_Attach.Image = global::SKYNET.Properties.Resources.ad_1;
            this.BTN_Attach.Location = new System.Drawing.Point(0, 0);
            this.BTN_Attach.Name = "BTN_Attach";
            this.BTN_Attach.Size = new System.Drawing.Size(49, 45);
            this.BTN_Attach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_Attach.TabIndex = 6;
            this.BTN_Attach.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.Chat_Info);
            this.panel11.Controls.Add(this.Chat_Tittle);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(562, 51);
            this.panel11.TabIndex = 2;
            // 
            // Chat_Info
            // 
            this.Chat_Info.AutoSize = true;
            this.Chat_Info.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chat_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Chat_Info.Location = new System.Drawing.Point(10, 27);
            this.Chat_Info.Name = "Chat_Info";
            this.Chat_Info.Size = new System.Drawing.Size(148, 17);
            this.Chat_Info.TabIndex = 1;
            this.Chat_Info.Text = "últ. vez hace 2 horas";
            // 
            // Chat_Tittle
            // 
            this.Chat_Tittle.AutoSize = true;
            this.Chat_Tittle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chat_Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Chat_Tittle.Location = new System.Drawing.Point(10, 8);
            this.Chat_Tittle.Name = "Chat_Tittle";
            this.Chat_Tittle.Size = new System.Drawing.Size(47, 16);
            this.Chat_Tittle.TabIndex = 0;
            this.Chat_Tittle.Text = "Lobby";
            this.Chat_Tittle.Click += new System.EventHandler(this.Chat_Tittle_Click);
            // 
            // ReloadTimer
            // 
            this.ReloadTimer.Enabled = true;
            this.ReloadTimer.Interval = 60000;
            this.ReloadTimer.Tick += new System.EventHandler(this.ReloadTimer_Tick);
            // 
            // LobbyGroup
            // 
            this.LobbyGroup.Activated = false;
            this.LobbyGroup.Avatar = global::SKYNET.Properties.Resources.Group;
            this.LobbyGroup.AvatarLength = 0;
            this.LobbyGroup.BackColor = System.Drawing.Color.White;
            this.LobbyGroup.ChatControl = null;
            this.LobbyGroup.ConnectedTime = new System.DateTime(((long)(0)));
            this.LobbyGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LobbyGroup.ID = "Lobby";
            this.LobbyGroup.IP = null;
            this.LobbyGroup.IsGroup = true;
            this.LobbyGroup.LastMessage = null;
            this.LobbyGroup.Location = new System.Drawing.Point(5, 0);
            this.LobbyGroup.MachineName = null;
            this.LobbyGroup.Margin = new System.Windows.Forms.Padding(36, 9, 3, 9);
            this.LobbyGroup.Name = "LobbyGroup";
            this.LobbyGroup.Notifications = 0;
            this.LobbyGroup.Padding = new System.Windows.Forms.Padding(1);
            this.LobbyGroup.Selected = false;
            this.LobbyGroup.Size = new System.Drawing.Size(234, 55);
            this.LobbyGroup.Status = UserStatus.Online;
            this.LobbyGroup.TabIndex = 9;
            this.LobbyGroup.UserName = "Lobby";
            this.LobbyGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.User_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(827, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.acceptBtn);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MinBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinPic)).EndInit();
            this.CloseBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.stcMain.Panel1.ResumeLayout(false);
            this.stcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stcMain)).EndInit();
            this.stcMain.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.Group_Pannel.ResumeLayout(false);
            this.Left_TopPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.txtContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Emoji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Attach)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button acceptBtn;
    private System.Windows.Forms.Button ok;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel CloseBox;
    private System.Windows.Forms.PictureBox ClosePic;
    private System.Windows.Forms.Panel Separator;
    private System.Windows.Forms.Panel panel1;
    private SplitContainerEx stcMain;
    private System.Windows.Forms.Panel Left_TopPanel;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Panel panel9;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.PictureBox MenuBox;
    private System.Windows.Forms.Panel panel10;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel MinBox;
    private System.Windows.Forms.PictureBox MinPic;
    private System.Windows.Forms.Panel panel11;
    private System.Windows.Forms.Panel panel13;
    private System.Windows.Forms.Panel txtContainer;
    private SKYNET.TXTMessage txtMessage;
    private System.Windows.Forms.PictureBox BTN_Emoji;
    private System.Windows.Forms.PictureBox BTN_Send;
    private System.Windows.Forms.PictureBox BTN_Attach;
    public SKYNET.SearchTextBox searchTextBox1;
    private System.Windows.Forms.Label Info;
    private System.Windows.Forms.Timer ReloadTimer;
    public MetroPanel UserContainer;
    private System.Windows.Forms.Panel Group_Pannel;
    public SKYNET.Controls.UserBox LobbyGroup;
    private System.Windows.Forms.Panel panel14;
    public System.Windows.Forms.Panel ChatContainer;
    private System.Windows.Forms.Label Chat_Tittle;
    private System.Windows.Forms.Label Chat_Info;
}
