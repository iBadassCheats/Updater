using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __Update__
{
    public partial class Runtime : Form
    {
        private static String This_is_OpenSource_xPkpwX()
        {
            return "Github: iBadassCheats";
        }

        private static String This_is_OpenSource_ZpDOlp()
        {
            return "Github: iBadassCheats";
        }

        private static String This_is_OpenSource_NRUkcm()
        {
            return "Github: iBadassCheats";
        }

        private static String This_is_OpenSource_HXLYkK()
        {
            return "Github: iBadassCheats";
        }

        public Runtime()
        {
            InitializeComponent();

            Settings.Filename = Settings.RandomString(16) + ".exe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.DownloadFile("AORelease.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.DownloadFile("SSORelease.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings.DownloadFile("KFRelease.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.DownloadFile("UTHGRelease.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Settings.DownloadFile("LCRelease.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings.DownloadFile("SE5Release.exe");
        }

        // Config/Folder

        private void button11_Click(object sender, EventArgs e)
        {
            if (File.Exists(Settings.Pathname + "\\Config.json"))
            {
                Process.Start("notepad.exe", Settings.Pathname + "\\Config.json");
            }
            else
            {
                MessageBox.Show("Config.json not Exits.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Settings.Pathname);
        }
    }
}
