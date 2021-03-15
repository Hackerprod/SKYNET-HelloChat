using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNET.Chat
{
    public class ChatManager
    {
        public static void ShowChat(string ID)
        {
            for (int i = 0; i < frmMain.frm.ChatContainer.Controls.Count; i++)
            {
                if (frmMain.frm.ChatContainer.Controls[i] is ChatControl)
                {
                    ChatControl chat = (ChatControl)frmMain.frm.ChatContainer.Controls[i];
                    if (chat.ChatID == ID)
                        chat.Visible = true;
                    else
                        chat.Visible = false;
                }
            }
        }

        public static ChatControl GetChatControl(string ID)
        {
            bool founded = false;

            ChatControl chatControl = new ChatControl("Lobby");
            chatControl.ChatID = "Lobby";
            chatControl.Dock = DockStyle.Fill;
            chatControl.Visible = false;

            for (int i = 0; i < frmMain.frm.ChatContainer.Controls.Count; i++)
            {
                if (frmMain.frm.ChatContainer.Controls[i] is ChatControl)
                {
                    ChatControl chat = (ChatControl)frmMain.frm.ChatContainer.Controls[i];
                    if (chat.ChatID == ID)
                    {
                        chatControl = chat;
                        founded = true;
                    }
                }
            }

            if (!founded)
            {
                frmMain.frm.ChatContainer.Controls.Add(chatControl);
            }

            return chatControl;
        }

        internal static void SaveChats()
        {
            for (int i = 0; i < frmMain.frm.ChatContainer.Controls.Count; i++)
            {
                if (frmMain.frm.ChatContainer.Controls[i] is ChatControl)
                {
                    ChatControl chat = (ChatControl)frmMain.frm.ChatContainer.Controls[i];
                    chat.Save();
                    //string DocumentText = chat.MessageHistory.ToString();
                    //File.WriteAllText(Path.Combine(modCommon.HistoryPath, chat.ChatID + ".htm"), DocumentText);
                }
            }
        }
    }
}
