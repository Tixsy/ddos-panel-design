using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel_example
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTime.Text = trackBar1.Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // These strings are here to identify the stuff in the api link
            string Host = tbHost.Text;
            string Port = tbPort.Text;
            string Method = cbMethod.Text;
            string Time = lblTime.Text;


            // This is the api link which you would get from your, Qbot, mirai or some other ddos hosting tool.
            // string API= wc.DownloadString($"https://www.APILINK.com/API.php?&host={Host}&port={Port}&method={Method}&time={Time}");

            // If the api is in the messagebox can just display what the api says instead of you typing it all out like the example below
            MessageBox.Show($"Attack Sent To {Host} for {Time} second/s with the port {Port} and the method {Method}");

            // For example if the api works, you do,   MessageBox.Show(API);
            // then it will display the api's text it shows.
        }
    }
}
