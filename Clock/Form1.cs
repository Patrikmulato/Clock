using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            circularProgressBar1.Invoke((MethodInvoker)delegate
            {
                circularProgressBar1.Text = DateTime.Now.ToString("hh:mm:ss");
                circularProgressBar1.SuperscriptText = DateTime.Now.ToString("tt");
            }
            );
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
