using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer1;
        private Stopwatch stopwatch1;
        private System.Timers.Timer timer2;
        private Stopwatch stopwatch2;
        string FormatTime(long milliseconds)
        {
            int totalSeconds = (int)(milliseconds / 1000);
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            int remainingMilliseconds = (int)(milliseconds % 1000);

            return string.Format("{0:00}分{1:00}秒", minutes, seconds, remainingMilliseconds);
        }
        public Form1()
        {
            InitializeComponent();

            // 初始化 Timer 对象
            timer1 = new System.Timers.Timer();
            timer1.Interval = 20;
            timer1.Elapsed += Timer_Tick1;
            timer1.AutoReset = true;
            timer1.SynchronizingObject = this;
            stopwatch1 = new Stopwatch();

            timer2 = new System.Timers.Timer();
            timer2.Interval = 20;
            timer2.Elapsed += Timer_Tick2;
            timer2.AutoReset = true;
            timer2.SynchronizingObject = this;
            stopwatch2 = new Stopwatch();

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            // 更新累计时间

            // 将累计时间显示在文本框中
            textBox1.Text = FormatTime(stopwatch1.ElapsedMilliseconds);
        }
        private void Timer_Tick2(object sender, EventArgs e)
        {
            // 更新累计时间

            // 将累计时间显示在文本框中
            textBox2.Text = FormatTime(stopwatch2.ElapsedMilliseconds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stopwatch1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void e1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopwatch1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            stopwatch2.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer2.Stop();
            stopwatch2.Stop();
        }
    }
}
