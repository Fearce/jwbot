using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LogMessage != LogMessageOld)
            {
                LogMsg(LogMessage);
                LogMessageOld = LogMessage;
            }
        }

        public static string LogMessage { get; set; }

        public static string LogMessageOld { get; set; }

        private void LogMsg(string msg)
        {
            richTextBox1.AppendText(Environment.NewLine + DateTime.Now + " " + msg);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Cycle cs = new Cycle();
            cs.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
