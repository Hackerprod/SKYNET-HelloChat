using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKYNET
{
    public class ChatSettings
    {
        public static string UserID
        {
            get
            {
                return modCommon.GetMacID(frmMain.Server.LocalEndPoint.Address);
            }
        }
        public static string UserName { get; set; }
        public static string MachineName { get; set; }
        public static bool WindowsStart { get; set; }
        public static long RefreshUsers { get; set; }
    }
}
