using SkynetManager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //modCommon.InitialiceApplication();

            /*IDisposable splashScreen = null;

            frmSplashScreen splashScreenForm = new frmSplashScreen();
            splashScreenForm.ShowSplashScreen();
            splashScreen = new FormSplashScreen(splashScreenForm);
            Thread.Sleep(1500);*/
            Application.Run(new frmMain());
            //Application.Run(new frmDark());

        }

    }
}
