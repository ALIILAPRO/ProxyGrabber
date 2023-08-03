using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proxy_Grabber___by_aliilapro__.frm
{
    public partial class main : Form
    {
        bool _openfollder = false;
        private static string FolderPath => string.Concat(Directory.GetCurrentDirectory(), "\\Proxy");
        public main()
        {
            InitializeComponent();
        }

        private void btn_http_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);
                txt_log.Clear();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebResponse response = (HttpWebResponse)((HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/ALIILAPRO/Proxy/main/http.txt")).GetResponse();
                string _gr = (new StreamReader(response.GetResponseStream())).ReadToEnd();
                MatchCollection matchCollections = (new Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches(_gr);
                txt_log.Text = _gr;
                File.WriteAllText(FolderPath + "\\Http-s.txt", txt_log.Text);
                if (_openfollder)
                {
                    Process.Start("Proxy");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_socks4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);
                txt_log.Clear();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebResponse response = (HttpWebResponse)((HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/ALIILAPRO/Proxy/main/socks4.txt")).GetResponse();
                string _gr = (new StreamReader(response.GetResponseStream())).ReadToEnd();
                MatchCollection matchCollections = (new Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches(_gr);
                txt_log.Text = _gr;
                File.WriteAllText(FolderPath + "\\socks4.txt", txt_log.Text);
                if (_openfollder)
                {
                    Process.Start("Proxy");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_socks5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);
                txt_log.Clear();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebResponse response = (HttpWebResponse)((HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/ALIILAPRO/Proxy/main/socks5.txt")).GetResponse();
                string _gr = (new StreamReader(response.GetResponseStream())).ReadToEnd();
                MatchCollection matchCollections = (new Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches(_gr);
                txt_log.Text = _gr;
                File.WriteAllText(FolderPath + "\\socks5.txt", txt_log.Text);
                if (_openfollder)
                {
                    Process.Start("Proxy");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chb_auto_CheckedChanged(object sender, EventArgs e)
        {
            bool @true = this.chb_auto.Checked;
            if (@true)
            {
                _openfollder = true;
            }
            else
            {
                _openfollder = false;
            }
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/aliilapro");
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/aliilapro");
        }
    }
}