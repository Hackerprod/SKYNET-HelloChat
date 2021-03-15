using SkynetChat;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using XNova_Utils;

namespace SKYNET.Chat
{
    public class MessageProcessor
    {
        internal static void ProcessMessagePayload(byte[] Payload, IPEndPoint endPoint)
        {
            frmMessage frmmessage = new frmMessage();

            string @string = Encoding.UTF8.GetString(Payload);

            LogProcess(@string);
            Chat_Message ReceivedMessage = new JavaScriptSerializer().Deserialize<Chat_Message>(@string);

            string ID = modCommon.GetMacID(endPoint.Address);

            ReceivedMessage.UserID = ID;
            ReceivedMessage.UserIP = endPoint.Address;
            
            frmMain.frm.cliente.OnMessageRecieved(new MessageEventArgs(ReceivedMessage));
        }

        private static void LogProcess(string @string)
        {
            frmLog Mplayer = Application.OpenForms.OfType<frmLog>().SingleOrDefault(pre => pre.Name == "frmLog");
            if (Mplayer != null)
            {
                Mplayer.Write(@string);
            }
        }

        private static void Transmit(Chat_Message message)
        {
            NetHelper.SendMessage(message);
        }
        private static List<string> MessagesID = new List<string>();
        public static void Process(Chat_Message message)
        {
            if (message.Content != null)
            {
                if (!string.IsNullOrEmpty(message.Content.MessageID))
                {
                    if (MessagesID.Contains(message.Content.MessageID))
                    {
                        return;
                    }
                    MessagesID.Add(message.Content.MessageID);
                }
            }

            switch (message.MessageType)
            {

                case MessageType.Message:

                    string Content = message.Content.Content;
                    message.Content.Time = DateTime.Now;

                    if (Content == "jajaja" || Content == "jeje" || Content == "haaa" || Content == "ª" || Content == "bye")
                    {
                        //SmileDirecto(content);
                    }
                    else if (Content == "Mute" || Content == "MuteOff")
                    {
                        //Mute(content);
                    }
                    else
                    {
                        frmMain.WriteChatMessages(ActionType.Message, message.UserID, message.Content, message.ColorID, message.UserName);
                    }
                    break;

                case MessageType.LogIn:

                    if (UserManager.ExistUserInChatControl(message.UserID))
                        return;
                    
                    User user = new User()
                    {
                        UserName = message.UserName,
                        AvatarLength = message.AvatarLength,
                        ConnectedTime = message.ConnectedTime,
                        ID = message.UserID,
                        IP = message.UserIP,
                        ImagePath = UserManager.GetUserAvatarFromID(message.UserID, false, message.UserName),
                        MachineName = message.MachineName,
                        Status = message.Status
                    };
                    
                    UserManager.AddUser(user);
                    
                    SKYNET.Chat_Message MessageReport = new SKYNET.Chat_Message()
                    {
                        MessageType = SKYNET.MessageType.Report,
                        ConnectedTime = DateTime.Now,
                        AvatarLength = 0,
                        ColorID = 0,
                        FormActivo = frmMain.frm.Focused,
                        UserName = Environment.UserName,
                        MachineName = Environment.MachineName,
                    };
                    Transmit(MessageReport);

                    break;
                case MessageType.Report:

                    User UserUpdated = new User()
                    {
                        UserName = message.UserName,
                        AvatarLength = message.AvatarLength,
                        ConnectedTime = message.ConnectedTime,
                        ID = message.UserID,
                        IP = message.UserIP,
                        ImagePath = UserManager.GetUserAvatarFromID(message.UserID, false, message.UserName),
                        MachineName = message.MachineName,
                        Status = message.Status
                    };
                    UserManager.AddOrUpdateUser(UserUpdated);

                    break;
                case MessageType.Reload:

                    if (message.UserID == ChatSettings.UserID)
                        return;

                    Transmit(new SKYNET.Chat_Message()
                    {
                        MessageType = SKYNET.MessageType.Report,
                        ConnectedTime = DateTime.Now,
                        AvatarLength = 0,
                        ColorID = 0,
                        FormActivo = frmMain.frm.Focused,
                        UserName = Environment.UserName,
                        MachineName = Environment.MachineName,
                    });

                    break;
                case MessageType.LogOut:

                    frmMain.WriteChatMessages(ActionType.Logout, message.UserID, message.Content, message.ColorID, message.UserName);
                    UserManager.RemoveUserBox(message.UserID);

                    break;
                case MessageType.Beep:

                    break;
                case MessageType.Activo:

                    UserManager.SetUserStatus(message.UserID, UserStatus.Activo);

                    break;
                case MessageType.Ocupado:

                    UserManager.SetUserStatus(message.UserID, UserStatus.Ocupado);

                    break;
                case MessageType.Ausente:

                    UserManager.SetUserStatus(message.UserID, UserStatus.Ausente);

                    break;
                case MessageType.Idle:

                    UserManager.SetUserStatus(message.UserID, UserStatus.Idle);

                    break;
                case MessageType.MP:
                    break;
                case MessageType.Update:

                    frmMain.UpdateProgram();

                    break;
                case MessageType.Activate:

                    UserManager.SetActivateBox(message.UserID, true);

                    break;
                case MessageType.Deactivate:

                    UserManager.SetActivateBox(message.UserID, false);

                    break;
                case MessageType.FormStatus:
                    break;
                case MessageType.Ping:
                    break;
                case MessageType.Smile:
                    break;
                case MessageType.Writing:
                    break;
                case MessageType.GetAvatar:
                    break;
                case MessageType.Mute:
                    break;
                case MessageType.GiveInfo:
                    break;
                case MessageType.Info:
                    break;
                case MessageType.Buzz:
                    break;
                case MessageType.HistoryChat:
                    break;
                case MessageType.Exit:
                    break;
                case MessageType.ChatResult:
                    break;
                case MessageType.ScreenShot:
                    break;
                case MessageType.GiveDateTime:
                    break;
                case MessageType.DateTimeResult:
                    break;
                case MessageType.PrivateChat:
                    break;
                default:
                    break;
            }

        }
    }
}
