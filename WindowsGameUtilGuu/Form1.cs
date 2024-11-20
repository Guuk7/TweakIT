using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NtApiDotNet;

namespace WindowsGameUtilGuu
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        public static Form1 Main;

        public Form1()
        {
            InitializeComponent();
            Main = this;
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calcula a nova posição do formulário
                this.Location = new Point(
                    this.Location.X + e.X - startPoint.X,
                    this.Location.Y + e.Y - startPoint.Y
                );
            }
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location; // Armazena a posição inicial do clique
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calcula a nova posição do formulário
                this.Location = new Point(
                    this.Location.X + e.X - startPoint.X,
                    this.Location.Y + e.Y - startPoint.Y
                );
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location; // Armazena a posição inicial do clique
            }
        }

        private void BtnDiscordLink_Click(object sender, EventArgs e)
        {
            Utilities.OpenUrl("https://discord.gg/xbKgMgdSj2");
        }

        private void BtnTelemetry_Click(object sender, EventArgs e)
        {

            Tweaks.DisableTelemetry();
        }

        private void BtnBackgroundApps_Click(object sender, EventArgs e)
        {
            Tweaks.DisableBackGroundApps();
        }

        private void BtnTransparency_Click(object sender, EventArgs e)
        {
            Tweaks.DisableTransparency();
        }

        private void BtnDisableDefender_Click(object sender, EventArgs e)
        {
            Tweaks.DisableDefender();
        }

        private void BtnDisableDriverUpdates_Click(object sender, EventArgs e)
        {
            Tweaks.DisableDriverUpdates();
        }


        private void BtnDisableSysmain_Click(object sender, EventArgs e)
        {
            Tweaks.DisableSysMain();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisableSearchIndex_Click(object sender, EventArgs e)
        {
            Tweaks.DisableSearchIndex();
        }

        private void Btn7zip_Click(object sender, EventArgs e)
        {
            ProgramDownload.Install7Zip();
        }

        private void BtnAutoruns_Click(object sender, EventArgs e)
        {
            ProgramDownload.InstallAutoruns();
        }

        private void BtnInstallDirectx_Click(object sender, EventArgs e)
        {
            ProgramDownload.InstallDirectx();
        }

        private void BtnVisualRuntime_Click(object sender, EventArgs e)
        {
            ProgramDownload.InstallVisualRuntime();
        }

        private void BtnInstallWebview_Click(object sender, EventArgs e)
        {
            ProgramDownload.InstallWebview();
        }

        private void BtnAmdDriver_Click(object sender, EventArgs e)
        {
            Utilities.OpenUrl("https://www.youtube.com/watch?v=yZyOp8AQT7A");
            Utilities.OpenUrl("https://www.amd.com/pt/support/download/drivers.html");
        }

        private void BtnYoutubeGuide_Click(object sender, EventArgs e)
        {
            Utilities.OpenUrl("https://www.youtube.com/watch?v=43a_i_n5fkU");
        }
    }
}
