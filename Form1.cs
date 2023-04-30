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
        public float roundLimit = 2  * 1000f;
        public float totalLimit = 10  * 1000f;

        private System.Timers.Timer timer1;
        private Stopwatch stopwatch1;
        private System.Timers.Timer timer2;
        private Stopwatch stopwatch2;
        private System.Timers.Timer timer3;
        private Stopwatch stopwatch3;
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

            timer3 = new System.Timers.Timer();
            timer3.Interval = 20;
            timer3.Elapsed += Timer_Tick3;
            timer3.AutoReset = true;
            timer3.SynchronizingObject = this;
            stopwatch3 = new Stopwatch();

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            textBox1.Text = FormatTime(stopwatch1.ElapsedMilliseconds);
            if (stopwatch1.IsRunning && stopwatch1.ElapsedMilliseconds >= roundLimit)
            {
                stopwatch1.Stop();
                textBox1.BackColor = Color.Yellow;
            }
        }
        private void Timer_Tick2(object sender, EventArgs e)
        {
            textBox2.Text = FormatTime(stopwatch2.ElapsedMilliseconds);
            if (stopwatch2.IsRunning && stopwatch2.ElapsedMilliseconds >= roundLimit)
            {
                stopwatch2.Stop();
                textBox2.BackColor = Color.Yellow;
            }
        }
        private void Timer_Tick3(object sender, EventArgs e)
        {
            textBox3.Text = FormatTime(stopwatch3.ElapsedMilliseconds);
            if (stopwatch3.IsRunning && stopwatch3.ElapsedMilliseconds >= totalLimit)
            {
                stopwatch3.Stop();
                textBox3.BackColor = Color.Red;
            }
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
            timer3.Start();
            stopwatch3.Start();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            stopwatch1.Reset();
            stopwatch2.Reset();
            stopwatch3.Reset();
            stopwatch1.Stop();
            stopwatch2.Stop();
            stopwatch3.Stop();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

    }
}
