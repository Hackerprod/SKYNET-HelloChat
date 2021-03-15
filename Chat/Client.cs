using SKYNET;
using SKYNET.Chat;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Windows;

namespace SkynetChat
{

    public class Client
    {
        public event EventHandler<MessageEventArgs> MessageReceived;
        public static string Userstate { get; set; }
        public virtual void OnMessageRecieved(MessageEventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        }
    }
    class Messages : Queue<Chat_Message>
    {
        public event EventHandler MessageQueued;

        public void Add(Chat_Message item)
        {
            base.Enqueue(item);
            MessageQueued?.Invoke(this, new EventArgs());
        }
    }

    public class MessageEventArgs : EventArgs
    {
        public Chat_Message ReceivedMessage = new Chat_Message();
        public static List<string> ListMessageID = new List<string>();

        public MessageEventArgs(Chat_Message content)
        {
            ReceivedMessage = content;
        }
    }

}
