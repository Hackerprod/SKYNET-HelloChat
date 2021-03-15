using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKYNET.Common;
using SKYNET.Properties;
using System.Net;
using System.Timers;
using System.Net.Sockets;

namespace SKYNET.Controls
{
    [Serializable]
    public partial class UserBox : UserControl
    {
        private readonly System.Timers.Timer _timer;
        private TextBox focus;
        public UserBox()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            focus = new TextBox();
            NotificationNumber.Maximum = 1000;
            Notifications = 0;
            SetAllControlsEvents();
            InitTimer();

            _timer.Start();
        }

        private void SetAllControlsEvents()
        {
            foreach (Control control in Controls)
            {
                control.MouseClick += Box_MouseClick;
                control.MouseDoubleClick += Box_MouseDoubleClick;

                if (control.HasChildren)
                    foreach (Control controlChildren in control.Controls)
                    {
                        controlChildren.MouseClick += Box_MouseClick;
                        controlChildren.MouseDoubleClick += Box_MouseDoubleClick;
                    }
            }
        }


        public IPAddress IP { get; set; }
        public DateTime ConnectedTime { get; set; }
        public string MachineName { get; set; }
        public bool Activated { get; set; }
        public int Notifications
        {
            get
            {
                return _Notifications;
            }
            set
            {
                _Notifications = value;
                NotificationNumber.Value = _Notifications;

                if (_Notifications == 0)
                {
                    NotificationNumber.Visible = false;
                }
                else
                {
                    NotificationNumber.Visible = true;
                }
            }
        }
        private int _Notifications;

        public bool IsGroup { get { return _IsGroup; } set { _IsGroup = value; } }
        private bool _IsGroup;

        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
                UserName_Label.Text = value;
            }
        }

        public UserStatus Status
        {
            get
            {
                return _Status;
            }
            set
            {
                if (IsGroup)
                {
                    Status_Picture.Image = (Image)default;
                    return;
                }

                switch (value)
                {
                    case UserStatus.Online:
                        if (_Status == UserStatus.Ausente) AvatarBox.Image = ImageManager.CropToCircle(_Avatar);
                        Status_Picture.Image = Resources.Status_Online;
                        break;
                    case UserStatus.Offline:
                        //Status_Picture.Image = Resources.Status_Offline;
                        break;
                    case UserStatus.Idle:
                        if (_Status == UserStatus.Ausente) AvatarBox.Image = ImageManager.CropToCircle(_Avatar);
                        Status_Picture.Image = Resources.Status_Idle;
                        break;
                    case UserStatus.Ocupado:
                        if (_Status == UserStatus.Ausente) AvatarBox.Image = ImageManager.CropToCircle(_Avatar);
                        Status_Picture.Image = Resources.Status_Busy;
                        break;
                    case UserStatus.Ausente:
                        AvatarBox.Image = ImageManager.ChangeOpacity(ImageManager.CropToCircle(_Avatar), 0.7f);
                        Status_Picture.Image = Resources.Status_Ausente;
                        break;
                    default:
                        break;
                }
                _Status = value;
            }
        }
        public string ID { get; set; }
        public int AvatarLength { get; set; }
        public Bitmap Avatar
        {
            get
            {
                return _Avatar;
            }
            set
            {
                _Avatar = value;
                AvatarBox.Image = ImageManager.CropToCircle(_Avatar);
            }
        }

        public bool Selected
        {
            get
            {
                return _Selected;
            }
            set
            {
                _Selected = value;

                SetColors(value);

            }
        }

        private void SetColors(bool value)
        {
            if (value)
            {
                this.BackColor = modCommon.Blue;
                panel1.BackColor = modCommon.Blue;
                Time.BackColor = modCommon.Blue;
                //Status_Box.BackColor = modCommon.Blue; 

                UserName_Label.ForeColor = Color.White;
                Log_Tittle.ForeColor = Color.White;
                Log_Text.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                panel1.BackColor = Color.White;
                Time.BackColor = Color.White;
                //Status_Box.BackColor = Color.White;

                UserName_Label.ForeColor = Color.FromArgb(100, 100, 100);
                Log_Tittle.ForeColor = Color.FromArgb(70, 138, 222);
                Log_Text.ForeColor = Color.FromArgb(147, 157, 160);
            }
        }

        public MessageContent LastMessage
        {
            get
            {
                return _LastMessage;
            }
            set
            {
                _LastMessage = value;

                MessageContent Message = value;

                if (value == null)
                    return;

                if (string.IsNullOrEmpty(Message.Content))
                    return;

                if (Message.Content.Contains("Se ha unido al chat"))
                {
                    if (UserName == "Lobby")
                        SetStatusText("", "El chat ha iniciado.");
                    else
                        SetStatusText(UserName + " ", Message.Content);
                    return;
                }

                string user = UserManager.GetUserNameFromID(Message.FromChatID);
                if (user == ChatSettings.UserName)
                    SetStatusText("Tú: ", Message.Content);
                else
                    SetStatusText(user + ": ", Message.Content);
                    
                //Time.Text = Message.Time;
            }
        }

        private void SetStatusText(string person, string content)
        {
            FontStyle style = FontStyle.Regular;
            if (Selected)
            {
                Log_Tittle.ForeColor = Color.White;
                Log_Text.ForeColor = Color.White;
            }
            else
            {
                Log_Tittle.ForeColor = Color.FromArgb(70, 138, 222);
                Log_Text.ForeColor = Color.FromArgb(147, 157, 160);
            }


            if (string.IsNullOrEmpty(person))
            {
                Log_Tittle.Visible = false;
                Log_Text.Location = Log_Tittle.Location;
                Log_Text.Text = content;
            }
            else
            {
                Log_Tittle.Visible = true;
                Log_Tittle.Text = person;

                SizeF size = modCommon.GetTextSize(Log_Tittle.Text, Log_Tittle.Font);

                Log_Text.Location = new Point(Log_Tittle.Location.X + (int)size.Width , Log_Tittle.Location.Y);
                Log_Text.Text = content;

            }
        }

        private MessageContent _LastMessage { get; set; }
        public ChatControl ChatControl { get; set; }

        private Bitmap _Avatar;
        private string _UserName;
        private bool _Selected;
        private UserStatus _Status;
        private void UserBox_Load(object sender, EventArgs e)
        {
            Status_Picture.Parent = AvatarBox;

            try
            {
                LastMessage = ChatControl.LastMessage;
            }
            catch { }
        }
        private void InitTimer()
        {
            _timer.AutoReset = false;
            _timer.Elapsed += _timer_Elapsed;
        }
        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!NetHelper.IsSomeNetworkRange(IP))
                return;

            if (IP.ToString() == modCommon.GetIp())
                return;


            if (modCommon.IsCableConnected())
            {
                IPEndPoint EndPoint = new IPEndPoint(IP, 25018);
                Socket sockets = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    DateTime SentDateTime = DateTime.Now;

                    IAsyncResult asyncResult = sockets.BeginConnect(EndPoint, new AsyncCallback((IAsyncResult ar) => { try { ((Socket)ar.AsyncState).EndConnect(ar); } catch { } }), sockets);

                    if (asyncResult.AsyncWaitHandle.WaitOne(5000, false))
                    {
                        sockets.Close();
                    }
                    else
                    {
                        //UserManager.RemoveUserBox(this);
                        sockets.Close();
                    }

                }
                catch
                {

                }
            }

            _timer.Interval = 60000 * 5; //5 Minutos
            _timer.Start();

        }
        private void Box_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        private void Box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
        }

        private void Box_Click(object sender, EventArgs e)
        {
            AvatarBox.Focus();
        }

    }
}
