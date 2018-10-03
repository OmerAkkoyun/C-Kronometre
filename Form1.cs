using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.uygulama_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0, saniye = 0, salise = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            timer3.Interval = 10;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (saniye==59)
            {
                saniye = -1;//aradaki 1salise farkını kapatmak için..
            } 
            saniye += 1;
            saniyeLabel.Text = Convert.ToString(saniye);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (salise==99)
            {
                salise = 0;
            }
            salise += 1;
            saliseLabel.Text = Convert.ToString(salise);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dakika = 0; saniye = 0; salise = 0;
            dakikaLabel.Text = Convert.ToString(dakika);
            saniyeLabel.Text = Convert.ToString(saniye);
            saliseLabel.Text = Convert.ToString(salise);

            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika += 1;
            dakikaLabel.Text = Convert.ToString(dakika);
        }
    }
}
