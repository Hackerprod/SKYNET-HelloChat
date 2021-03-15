using Microsoft.VisualBasic.CompilerServices;
using mshtml;
using SKYNET;
using SKYNET.Chat;
using SKYNET.Common;
using SKYNET.Controls;
using SKYNET.Properties;
using SkynetChat;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Transparencia;
using XNova_Utils;

public partial class frmMain : Form
{
    private bool mouseDown;     //Mover ventana
    private Point lastLocation; //Mover ventana

    public static frmMain frm;

    private SKYNET.Chat_Message mensage;
    private SkynetChat.Messages messages;

    private readonly System.Timers.Timer _timer;

    public Client cliente { get; set; }
    public string CurrentChatID { get; set; }

    private int yy;
    UserBox SelectedUserBox;

    public StringBuilder HtmlString;
    public static DiscoveryServer Server;
    public frmMain()
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos
        frm = this;

        CreateDirectories();

        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(); //WebBrowser Emulation

        _timer = new System.Timers.Timer();

        HtmlString = new StringBuilder();
        //modCommon.SetPosition(Handle, this);
        searchTextBox1.TextChanged += SearchTextBox_TextChanged;

        cliente = new Client();
        cliente.MessageReceived += new EventHandler<MessageEventArgs>(client_MessageReceived);

        //Borrar por prueba
        messages = new Messages();
        messages.MessageQueued += new EventHandler(Messages_MessageQueued);

        //panel11.Visible = false;
        panel13.Visible = false;



        StartChat();

        
    }
    private void FrmMain_Load(object sender, EventArgs e)
    {

    }
    public static void CreateDirectories()
    {
        if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Data")))
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Data"));

        if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Data", "Avatars")))
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Data", "Avatars"));

        if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images")))
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images"));

        modCommon.TEMP_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "[Skynet] Hello Chat", "Temp");
        modCommon.SCREENSHOT_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "[Skynet] Hello Chat", "Screenshots");
        modCommon.USERS_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "[Skynet] Hello Chat", "Users");

        if (!Directory.Exists(modCommon.USERS_PATH))
            Directory.CreateDirectory(modCommon.USERS_PATH);

        if (!Directory.Exists(modCommon.TEMP_PATH))
            Directory.CreateDirectory(modCommon.TEMP_PATH);

        if (!Directory.Exists(Path.Combine(modCommon.TEMP_PATH, "Avatars")))
            Directory.CreateDirectory(Path.Combine(modCommon.TEMP_PATH, "Avatars"));

        if (!Directory.Exists(modCommon.SCREENSHOT_PATH))
            Directory.CreateDirectory(modCommon.SCREENSHOT_PATH);

        if (!Directory.Exists(Path.Combine(modCommon.TEMP_PATH, "Letters")))
            Directory.CreateDirectory(Path.Combine(modCommon.TEMP_PATH, "Letters"));

        modCommon.HistoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "[Skynet] Hello Chat", "History");

        if (!Directory.Exists(modCommon.HistoryPath))
            Directory.CreateDirectory(modCommon.HistoryPath);

        if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Background.jpg")))
            Resources.Background.Save(Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Background.jpg"));

        if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Background_2.jpg")))
            Resources.Background_2.Save(Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Background_2.jpg"));
    }

    public void client_MessageReceived(object sender, MessageEventArgs e)
    {
        try { messages.Add(e.ReceivedMessage); } catch { }
    }

    private void StartChat()
    {
        Server = new DiscoveryServer();
        if (!Server.Start())
        {
            modCommon.Show("Ups... no se pudo comenzar la escucha.");
        }

        ChatSettings.UserName = "Hackerprod";

        Group_Pannel.Controls.Add(this.LobbyGroup);

        ChatControl chatControl = new ChatControl("Lobby");
        chatControl.ChatID = "Lobby";
        chatControl.Dock = DockStyle.Fill;
        chatControl.Visible = false;

        LobbyGroup.ChatControl = chatControl;
        ChatContainer.Controls.Add(chatControl);

        ChatManager.ShowChat("Lobby");



        Chat_Message message = new Chat_Message()
        {
            MessageType = SKYNET.MessageType.LogIn,
            ConnectedTime = DateTime.Now,
            AvatarLength = 0,
            ColorID = 0,
            FormActivo = Focused,
            UserName = Environment.UserName,
            MachineName = Environment.MachineName,
        };
        Transmit(message);

        LobbyGroup.Selected = true;
        CurrentChatID = "Lobby";
        //ChatManager.ShowChat("Lobby");

        InitTimer();
        _timer.Start();

        User Lobby = new User()
        {
            UserName = "Yohel.com",
            IP = IPAddress.Parse("0.0.0.0"),
            ID = DateTime.Now.ToString(),
            //Avatar = Resources.Group,
        };
        //UserManager.AddUser(Lobby);
    }
    private void InitTimer()
    {
        _timer.AutoReset = false;
        _timer.Elapsed += _timer_Elapsed;
    }
    private void _timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        Transmit(new Small_Message() { MessageType = MessageType.Reload });

        _timer.Interval = 60000 * 1; //5 Minutos
        _timer.Start();

    }


    public static void WriteChatMessages(ActionType actionType, string UserID, MessageContent content, int userSelectedColor, string nickName = "")
    {
        string Username = nickName;

        if (string.IsNullOrEmpty(Username))
            Username = UserManager.GetUserNameFromID(UserID);

        switch (actionType)
        {
            case ActionType.Rename:
                //frm.WriteChat(UserID, HtmlHelper.GetRenameHtml(Username, content.FromChatID, DateTime.Now), content);
                break;
            case ActionType.Login:
                //frm.WriteChat(UserID, HtmlHelper.GetIngresoHtml(Username, DateTime.Now), content);
                break;
            case ActionType.Logout:
                //frm.WriteChat(UserID, HtmlHelper.GetDesconectoHtml(Username, DateTime.Now), content);
                break;
            case ActionType.Empty:
                //frm.WriteChat(UserID, HtmlHelper.GetAlertHtml(content.FromChatID, Username), content);
                break;
            case ActionType.Message:
                Application.DoEvents();

                /*if (!WinMod.IsActiveMainWindow())
                {
                    frm.notifyIcons[0] = Resources.SC_Clean;
                    frm.notifyIcons[1] = Resources.SC_Message;
                    AnimateNotifyIcon.Animate(frm.NotifyIcon1, frm, frm.notifyIcons, 400);
                    FlashWin.Start(frm.Handle);
                }*/
                //Bubble Message 

                if (content.ToChatID == "Lobby")
                {

                    frm.WriteChat(content.ToChatID, content);
                    UserBox control = UserManager.GetUserBoxFromID(content.ToChatID);
                    if (control != null)
                    {
                        control.LastMessage = new MessageContent() { Content = content.Content, FromChatID = content.FromChatID, ToChatID = content.ToChatID, Time = DateTime.Now };
                    }
                }
                else if (content.ToChatID == UserID)
                {
                    frm.WriteChat(content.ToChatID, content);
                    UserBox control = UserManager.GetUserBoxFromID(content.ToChatID);
                    if (control != null)
                    {
                        control.LastMessage = new MessageContent() { Content = content.Content, FromChatID = content.FromChatID, ToChatID = content.ToChatID, Time = DateTime.Now };
                    }
                }
                else if (content.FromChatID == UserID)
                {
                    frm.WriteChat(content.ToChatID, content);
                    UserBox control = UserManager.GetUserBoxFromID(content.ToChatID);
                    if (control != null)
                    {
                        control.LastMessage = new MessageContent() { Content = content.Content, FromChatID = content.FromChatID, ToChatID = content.ToChatID, Time = DateTime.Now };
                    }
                }
                //modCommon.Show(content.ToChatID);

                /*frm.beep = new SoundPlayer(Resources.beep1);
                if (!Muted)
                    frm.beep.Play();*/

                break;
            case ActionType.PrivateMessage:
                /*frm.beep = new SoundPlayer(Resources.beep1);
                if (!Muted)
                    frm.beep.Play();*/
                break;
            case ActionType.FileDrag:
                //frm.WriteChat(UserID, HtmlHelper.GetNameHtml(UserID, DateTime.Now, userName: nickName) + HtmlHelper.GetMessage(UserID, content.Content, userSelectedColor.ToString()), content.MessageID);
                break;
            case ActionType.ScreenShot:
                //frm.WriteChat(UserID, HtmlHelper.GetNameHtml(UserID, DateTime.Now, userName: nickName), content.MessageID);
                //frm.WriteChat(UserID, HtmlHelper.GetMessage(UserID, HtmlHelper.GetScreenshot(content.Content), userSelectedColor.ToString()), content.MessageID);
                break;
            default:
                break;
        }
    }
    public void WriteChat(string ID, MessageContent messageContent)
    {
        ChatControl chat = ChatManager.GetChatControl(ID);
        chat.WriteChat(messageContent);
    }

    public static void Transmit(BaseMessage message)
    {
        NetHelper.SendMessage(message);
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
    private void Control_MouseMove(object sender, MouseEventArgs e)
    {
        try
        {
            Control control = (Control)sender;
            if (control is PictureBox)
            {
                switch (control.Name)
                {
                    case "ClosePic": CloseBox.BackColor = Color.FromArgb(232, 17, 35); break;
                    case "MinPic": MinBox.BackColor = Color.FromArgb(229, 229, 229); break;
                }
            }
            if (control is Panel)
            {
                switch (control.Name)
                {
                    case "CloseBox": CloseBox.BackColor = Color.FromArgb(232, 17, 35); break;
                    case "MinBox": MinBox.BackColor = Color.FromArgb(229, 229, 229); break;
                }
            }
        }
        catch { }
    }

    private void Control_MouseLeave(object sender, EventArgs e)
    {
        MinBox.BackColor = Color.FromArgb(241, 241, 241);
        CloseBox.BackColor = Color.FromArgb(241, 241, 241);
    }

    private void CloseBox_Click(object sender, EventArgs e)
    {
        Close();
    }



    public void User_MouseClick(object sender, MouseEventArgs e)
    {
        if (sender is UserBox)
        {
            UserBox Box = (UserBox)sender;
            UserManager.DeselectAll();
            Box.Selected = true;
            Box.Notifications = 0;
            SelectedUserBox = Box;

            CurrentChatID = Box.ID;
            ChatManager.ShowChat(Box.ID);

            Chat_Tittle.Text = Box.UserName;
        }
       // modCommon.Show(ChatContainer.Controls.Count);
    }
    int count = 4;

    private void MenuBox_Click(object sender, EventArgs e)
    {
        string user = modCommon.GetUniqueAlphaNumericID();
        User RamdomUser = new User()
        {
            UserName = user,
            IP = IPAddress.Parse("0.0.0.0"),
            ID = user,
            Avatar = (Bitmap)ImageManager.CropToCircle(ImageManager.CreateLetterImage(user))
        };
        UserManager.AddUser(RamdomUser);
        return;

        Transmit(new Small_Message() { MessageType = MessageType.Reload });

        return;

        count = count * 2;
        UserBox lobby = UserManager.GetUserBoxFromID("Lobby");
        lobby.Notifications = count;

        return;



        //Transmit(new Small_Message() { messageType = MessageType.Reload });


        return;

        if (count == 0)
        {
            SelectedUserBox.Status = UserStatus.Ausente;
            count++;
        }
        else
        {
            SelectedUserBox.Status = UserStatus.Online;
            count = 0;
        }
    }


    private void SearchTextBox_TextChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < UserContainer.Controls.Count; i++)
        {
            if (UserContainer.Controls[i] is UserBox)
            {
                UserBox Box = (UserBox)UserContainer.Controls[i];
                if (Box.UserName.StartsWith(searchTextBox1.Text))
                    Box.Visible = true;
                else
                    Box.Visible = false;

            }
        }
    }


    public void webChat_Navigating(object sender, WebBrowserNavigatingEventArgs e)
    {
        DoDragDrop(e.Url.ToString(), DragDropEffects.Copy);
        e.Cancel = true;
        //TransmitFile(modCommon.convertURI(e.Url.ToString()));
    }
    public void OnDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
        //WireUpButtonEvents();
    }
    public void AssignStyleSheet(WebBrowser wBrowser)
    {
        string TelegramCSS = Resources.Telegram;

        IHTMLStyleSheet2 instance = (IHTMLStyleSheet2)((IHTMLDocument2)wBrowser.Document.DomDocument).createStyleSheet("", 0);

        NewLateBinding.LateSet(instance, null, "cssText", new object[1]
        {
                HtmlHelper.GetStyles() + "\r\n" + css.GetMyCSS() + "\r\n" + TelegramCSS
        }, null, null);

        HtmlElement htmlElement =  wBrowser.Document.GetElementsByTagName("head")[0];
        HtmlElement htmlElement2 = wBrowser.Document.CreateElement("script");
        IHTMLScriptElement iHTMLScriptElement = (IHTMLScriptElement)htmlElement2.DomElement;

        iHTMLScriptElement.text = HtmlHelper.GetJavascript();

        htmlElement.AppendChild(htmlElement2);
    }
    public void Messages_MessageQueued(object sender, EventArgs e)
    {
        UpdateChat();
    }
    public void UpdateChat()
    {
        try
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateChat));
            }
            else
            {
                messages.Dequeue().ProcessMessage();
                //FlashWindow(Handle, false);
            }
        }
        catch
        {
            Console.WriteLine("lol, fail");
        }
    }



    private void BTN_Send_Click(object sender, EventArgs e)
    {
        MessageContent messageContent = new MessageContent();
        messageContent.ToChatID = CurrentChatID;
        messageContent.FromChatID = ChatSettings.UserID;
        messageContent.Content = txtMessage.Text;


        txtMessage.Clear();
        txtMessage.textBox.Text = string.Empty;
        Transmit(new Text_Message() { MessageType = MessageType.Message, Content = messageContent });

    }

    private void TxtMessage_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.Return)
        {
            MessageContent messageContent = new MessageContent();
            messageContent.ToChatID = CurrentChatID;
            messageContent.FromChatID = ChatSettings.UserID;
            messageContent.Content = txtMessage.Text;

            txtMessage.Clear();

            Transmit(new Text_Message() { MessageType = MessageType.Message, Content = messageContent });
        }
        else
        {
            /*
            int Lines = txtMessage.Lines;
            int ContainerWidth = txtContainer.Size.Width;

            switch (Lines)
            {
                case 1:
                    txtContainer.Size = new System.Drawing.Size(ContainerWidth, 45);
                    break;
                case 2:
                    txtContainer.Size = new System.Drawing.Size(ContainerWidth, 60);
                    break;
                case 3:
                    txtContainer.Size = new System.Drawing.Size(ContainerWidth, 75);
                    break;
                case 4:
                    txtContainer.Size = new System.Drawing.Size(ContainerWidth, 90);
                    break;
                case 5:
                    txtContainer.Size = new System.Drawing.Size(ContainerWidth, 105);
                    break;
                default:
                    break;
            }
            */
        }
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        ChatManager.SaveChats();
        Server.Disconnect();
    }

    private void ReloadTimer_Tick(object sender, EventArgs e)
    {
        Transmit(new Small_Message() { MessageType = MessageType.Reload });
    }

    private void Minimize_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }
    public static void UpdateProgram()
    {

    }

    private void Chat_Tittle_Click(object sender, EventArgs e)
    {
        frmLog log = new frmLog();
        log.Show();
    }
}

