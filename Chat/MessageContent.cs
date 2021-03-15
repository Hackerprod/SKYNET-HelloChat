using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKYNET
{
    [Serializable]
    public class MessageContent
    {
        public string ToChatID { get; set; }
        public string FromChatID { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public string MessageID { get { return modCommon.GetUniqueAlphaNumericID(); } }

    }
}
