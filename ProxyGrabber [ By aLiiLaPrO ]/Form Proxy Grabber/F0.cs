using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProxyGrabber___By_aLiiLaPrO__.Form_Proxy_Grabber
{
    public partial class F0 : Form
    {

        public F0()
        {
            InitializeComponent();
        }
        private static string FolderPath => string.Concat(Directory.GetCurrentDirectory(),"\\[Proxy Grabber]");

        private void F0_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(FolderPath))Directory.CreateDirectory(FolderPath);
            txtlog.AppendText("--------------------------------");
            txtlog.AppendText(Environment.NewLine + "Proxy Grabber Running");
            txtlog.AppendText(Environment.NewLine + "App Version 1.0");
            txtlog.AppendText(Environment.NewLine + "Create By aLiiLaPrO");
            txtlog.AppendText(Environment.NewLine + "--------------------------------");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtlog.AppendText(Environment.NewLine + "Start Grabb Proxy Http");
            HttpWebResponse response = (HttpWebResponse)((HttpWebRequest)WebRequest.Create("https://api.proxyscrape.com/?request=getproxies&proxytype=http&timeout=10000&country=all&anonymity=all&ssl=yes")).GetResponse();
            string end = (new StreamReader(response.GetResponseStream())).ReadToEnd();
            MatchCollection matchCollections = (new Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches(end);
            this.txtproxyh.Text = end;
            File.WriteAllText(FolderPath + "\\Proxy-Http.txt", txtproxyh.Text);
            txtlog.AppendText(Environment.NewLine + "=> Proxy Http Successfully Grabbed & Save.");
            txtlog.AppendText(Environment.NewLine + "Start Grabb Proxy Socks4");
            HttpWebResponse response1 = (HttpWebResponse)((HttpWebRequest)WebRequest.Create("https://api.proxyscrape.com?request=getproxies&proxytype=socks4&timeout=10000&country=all")).GetResponse();
            string end1 = (new StreamReader(response1.GetResponseStream())).ReadToEnd();
            MatchCollection matchCollections1 = (new Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches(end1);
            this.txtproxys4.Text = end1;
            File.WriteAllText(FolderPath + "\\Proxy-Socks4.txt", txtproxys4.Text);
            txtlog.AppendText(Environment.NewLine + "=> Proxy Socks4 Successfully Grabbed & Save.");
            txtlog.AppendText(Environment.NewLine + "Start Grabb Proxy Socks5");
            HttpWebResponse response2 = (HttpWebResponse)((HttpWebRequest)WebRequest.Create("https://api.proxyscrape.com?request=getproxies&proxytype=socks5&timeout=10000&country=all")).GetResponse();
            string end2 = (new StreamReader(response2.GetResponseStream())).ReadToEnd();
            MatchCollection matchCollections2 = (new Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")).Matches(end2);
            this.txtproxys5.Text = end2;
            File.WriteAllText(FolderPath + "\\Proxy-Socks5.txt", txtproxys5.Text);
            txtlog.AppendText(Environment.NewLine + "=> Proxy Socks5 Successfully Grabbed & Save.");
            txtlog.AppendText(Environment.NewLine + "--------------------------------");
            txtlog.AppendText(Environment.NewLine + "Finish.");
            Process.Start("[Proxy Grabber]");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://aliilapro.blog.ir");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/source_pro");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/aliilapro");
        }
    }
}
