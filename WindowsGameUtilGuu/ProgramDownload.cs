using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsGameUtilGuu
{
    internal class ProgramDownload
    {
        internal static void Install7Zip()
        {
            string downloadUrl = "https://7-zip.org/a/7z2408-x64.exe";
            string fileName = "7z2408-x64.exe";
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string downloadPath = Path.Combine(downloadsPath, fileName);

            if (File.Exists(downloadPath))
            {

            }
            else
            {
                Utilities.StatusTitle("Downloading 7-zip...");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(downloadUrl, downloadPath);
                }

            }
            Utilities.StartProcess(downloadsPath, fileName);
            Utilities.ResetTitle();
        }

        internal static void InstallAutoruns()
        {
            string downloadUrl = "https://cdn.discordapp.com/attachments/1308610810599309342/1308610854463340646/Autoruns.exe?ex=673e9254&is=673d40d4&hm=44940b0407ad9097847117732e04b1bb54afbadf30768fbd2b16a4b5ccb85faa&";
            string fileName = "Autoruns.exe";
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string downloadPath = Path.Combine(downloadsPath, fileName);

            if (File.Exists(downloadPath))
            {

            }
            else
            {
                Utilities.StatusTitle("Downloading Autoruns...");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(downloadUrl, downloadPath);
                }

            }
            Utilities.StartProcess(downloadsPath, fileName);
            Utilities.ResetTitle();
        }
        internal static void InstallDirectx()
        {
            string downloadUrl = "https://download.microsoft.com/download/8/4/A/84A35BF1-DAFE-4AE8-82AF-AD2AE20B6B14/directx_Jun2010_redist.exe";
            string fileName = "directx_Jun2010_redist.exe";
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string downloadPath = Path.Combine(downloadsPath, fileName);

            if (File.Exists(downloadPath))
            {

            }
            else
            {
                Utilities.StatusTitle("Downloading Directx...");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(downloadUrl, downloadPath);
                }

            }
            Utilities.StartProcess(downloadsPath, fileName);
            Utilities.ResetTitle();
        }

        internal static void InstallVisualRuntime()
        {
            string downloadUrl = "https://github.com/abbodi1406/vcredist/releases/download/v0.85.0/VisualCppRedist_AIO_x86_x64.exe";
            string fileName = "VisualCppRedist_AIO_x86_x64.exe";
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string downloadPath = Path.Combine(downloadsPath, fileName);

            if (File.Exists(downloadPath))
            {

            }
            else
            {
                Utilities.StatusTitle("Downloading Visual C++ Runtime...");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(downloadUrl, downloadPath);
                }

            }
            Utilities.StartProcess(downloadsPath, fileName);
            Utilities.ResetTitle();
        }

        internal static void InstallWebview()
        {
            string downloadUrl = "https://go.microsoft.com/fwlink/p/?LinkId=2124703";
            string fileName = "MicrosoftEdgeWebview2Setup.exe";
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string downloadPath = Path.Combine(downloadsPath, fileName);

            if (File.Exists(downloadPath))
            {

            }
            else
            {
                Utilities.StatusTitle("Downloading Webview Runtime...");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(downloadUrl, downloadPath);
                }

            }
            Utilities.StartProcess(downloadsPath, fileName);
            Utilities.ResetTitle();
        }
    }
}