using SKYNET.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SKYNET
{
    public interface BaseMessage
    {
        MessageType MessageType { get; set; }
    }

    public class Chat_Message : BaseMessage
    {
        public string UserName { get; set; }
        public MessageType MessageType { get; set; }
        public MessageContent Content { get; set; }
        public int ColorID { get; set; }
        public string MachineName { get; set; }
        public IPAddress UserIP { get; set; }
        public string UserID { get; set; }
        public UserStatus Status { get; set; }
        public bool FormActivo { get; set; }
        public int AvatarLength { get; set; }
        public DateTime ConnectedTime { get; set; }
        public string IdleTime { get; set; }
        public bool Writing { get; set; }

        internal void ProcessMessage()
        {
            MessageProcessor.Process(this);
        }
    }
    public class Writting_Message : BaseMessage
    {
        public MessageType MessageType { get; set; }
        public bool Writing { get; set; }
    }
    public class StatusForm_Message
    {
        public MessageType messageType { get; set; }
        public string FormActivo { get; set; }
    }
    public class Avatar_Message : BaseMessage
    {
        public MessageType MessageType { get; set; }
        public int AvatarLength { get; set; }
    }
    public class Text_Message : BaseMessage
    {
        public MessageType MessageType { get; set; }
        public MessageContent Content { get; set; }
        public string MessageID { get { return modCommon.GetUniqueAlphaNumericID(); } }

    }
    public class Small_Message : BaseMessage
    {
        public MessageType MessageType { get; set; }
    }
}
