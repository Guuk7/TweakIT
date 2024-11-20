using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;



namespace WindowsGameUtilGuu
{
    internal class Utilities
    {

        internal static void StopService(string serviceName)
        {
            ServiceController sc = new ServiceController(serviceName);
            if (sc.Status == ServiceControllerStatus.Running)
            {
                sc.Stop();
            }
        }
        internal static void OpenUrl(string url)
        {
            Process.Start(url);
        }

        internal static void DeleteRegistryValue(string keyPath, string valueName)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath, writable: true))
            {
                if (key != null && key.GetValue(valueName) != null)
                {
                    key.DeleteValue(valueName);
                }
            }
        }

        internal static void StatusTitle(string title)
        {
            Form1.Main.TitleLabel.Text = title;
            Application.DoEvents();
        }
        internal static void ResetTitle()
        {
            Form1.Main.TitleLabel.Text = "dsc.gg/guuoti";
            Application.DoEvents();
        }

        internal static void StartProcess(string path, string fileName)
        {
            string fullPath = System.IO.Path.Combine(path, fileName);
            Process.Start(fullPath);
        }
    }
}
