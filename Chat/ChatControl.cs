using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkynetChat;
using mshtml;
using Microsoft.VisualBasic.CompilerServices;
using SKYNET.Properties;
using System.IO;
using SKYNET.Controls;
using System.Diagnostics;
using System.Web.Script.Serialization;

namespace SKYNET
{
    public partial class ChatControl : UserControl
    {
        public string ChatID { get; set; }
        public MessageContent LastMessage { get; private set; }
        private string LastMessageUserID { get; set; }

        public StringBuilder MessageHistory;

        List<MessageContent> MessageContents;
        public ChatControl(string iD)
        {
            InitializeComponent();
            ChatID = iD;
            MessageContents = new List<MessageContent>();
            MessageHistory = new StringBuilder();

            StartWebBrowser();
        }

        private void StartWebBrowser()
        {
            webChat.AllowWebBrowserDrop = true; //Picha pero me carga lo que suelto
            webChat.Navigate("about:blank");
            while (webChat.Document == null || webChat.Document.Body == null)
                Application.DoEvents();

            modCommon.HistoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "[Skynet] Hello Chat", "History");
            string HistoryFile = Path.Combine(modCommon.HistoryPath, ChatID + ".htm");

            /*if (File.Exists(HistoryFile))
            {
                string DocumentText = File.ReadAllText(HistoryFile);
                webChat.Document.OpenNew(true).Write(DocumentText);

            }
            else
            {

            }*/

            webChat.Document.OpenNew(true).Write($"<html>\n<head>\n" +
                               $"{HtmlHelper.GetHtmlIEVersion()}\n" +
                               $"<style>{GetBackgroundImage()}</style>\n" +
                               //                                       $"<link rel=\"stylesheet\" href=\"c:/telegram.css\" >\n" +
                               $"</head>\n<body class=\"non_osx non_msie is_2x\"><br>\n" +
                               $"<div class=\"im_history_col_wrap im_history_loaded\" style=\"\">\n" +
                               $"<div class=\"im_history_messages im_history_messages_group\" style=\"\">\n");



            webChat.ScriptErrorsSuppressed = true; //Evitar mensaje de error por script

            //MasterInitiate();
            AssignStyleSheet(webChat);

            //LoadHistoryChat();
            LoadChat();
        }

        public void AssignStyleSheet(WebBrowser wBrowser)
        {
            string TelegramCSS = Resources.Telegram;

            IHTMLStyleSheet2 instance = (IHTMLStyleSheet2)((IHTMLDocument2)wBrowser.Document.DomDocument).createStyleSheet("", 0);

            NewLateBinding.LateSet(instance, null, "cssText", new object[1]
            {
                HtmlHelper.GetStyles() + "\r\n" + TelegramCSS + "\r\n"
            }, null, null);

            HtmlElement htmlElement = wBrowser.Document.GetElementsByTagName("head")[0];
            HtmlElement htmlElement2 = wBrowser.Document.CreateElement("script");
            IHTMLScriptElement iHTMLScriptElement = (IHTMLScriptElement)htmlElement2.DomElement;

            iHTMLScriptElement.text = HtmlHelper.GetJavascript();

            htmlElement.AppendChild(htmlElement2);
        }
        private string GetBackgroundImage()
        {
            /*if (string.IsNullOrEmpty(modCommon.TEMP_PATH))
            {
                modCommon.TEMP_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "[Skynet] Hello Chat", "Temp");
            }*/

            //string filename = modCommon.TEMP_PATH + @"\Background.jpg";
            //filename = filename.Replace(@"\", "/");

            string filename = "c:/Background.jpg";

            return @"
body
{
    background-image: url(" + filename + @");
    background-attachment: fixed;
    background-size: 100% 100%;   
}
        ";

        }



        private void ChatControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {

            }
        }
        public void WriteChat(MessageContent messageContent, bool isLoadingHistory = false)
        {
            UserBox ubox = UserManager.GetUserBoxFromID(messageContent.FromChatID);
            string message = HtmlHelper.GetMessageBody(messageContent, ubox.UserName, true);

            MessageHistory.Append(message);

            webChat.Document.Write(message);
            //webChat.Document.Write(content);
            webChat.Document.Window.ScrollTo(0, webChat.Document.Body.ScrollRectangle.Height);
            WireUpButtonEvents();

            if (isLoadingHistory)
                return;

            UserBox box = UserManager.GetUserBoxFromID(ChatID);
            if (box != null)
            {
                if (box.Selected)
                    box.Notifications = 0;
                else
                    box.Notifications += 1;
            }
            if (messageContent != null)
                MessageContents.Add(messageContent);

            LastMessageUserID = messageContent.FromChatID;

        }


        public void WireUpButtonEvents()
        {

            HtmlElementCollection elements = webChat.Document.GetElementsByTagName("IMG");
            for (int i = 0; i < elements.Count; i++)
            {
                HtmlElement el = elements[i];
                el.AttachEventHandler("ondblclick", (sender, args) => OnElementClicked(el, EventArgs.Empty));
            }
            HtmlElementCollection body = webChat.Document.GetElementsByTagName("BODY");
            for (int i = 0; i < body.Count; i++)
            {
                HtmlElement el = body[i];
                el.AttachEventHandler("onclick", (sender, args) => OnElementSelect(el, EventArgs.Empty));
            }

        }
        protected void OnElementClicked(object sender, EventArgs args)
        {
            HtmlElement el = sender as HtmlElement;
            string elType = el.GetAttribute("type");
            string elName = el.GetAttribute("name");
            string elValue = el.GetAttribute("value");

            //HtmlHelper.OpenFile(modCommon.convertURI(el.Id));

        }
        protected void OnElementSelect(object sender, EventArgs args)
        {
            //Hecho por mi
            string selection = webChat.Document.InvokeScript("getSelectionText").ToString();
            if (!string.IsNullOrEmpty(selection))
            {
                Clipboard.Clear();
                Clipboard.SetText(selection, TextDataFormat.UnicodeText);
            }
        }

        public void Save()
        {
            string json = new JavaScriptSerializer().Serialize(MessageContents);
            File.WriteAllText(Path.Combine(modCommon.HistoryPath, ChatID + ".json"), json);
        }
        public void LoadChat()
        {
            if (File.Exists(Path.Combine(modCommon.HistoryPath, ChatID + ".json")))
            {
                string json = File.ReadAllText(Path.Combine(modCommon.HistoryPath, ChatID + ".json"));

                MessageContents = new JavaScriptSerializer().Deserialize<List<MessageContent>>(json);

                foreach (MessageContent message in MessageContents)
                {
                    WriteChat(message, true);
                    LastMessage = message;
                }
            }
            else
            {
                LastMessage = new MessageContent() { Content = "Se ha unido al chat"};
            }
        }

    }
}
