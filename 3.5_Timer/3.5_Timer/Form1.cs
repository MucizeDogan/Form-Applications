using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._5_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 30)
            {
                timer1.Stop();
                MessageBox.Show("30. Saniyeye ulaşıldı!");
                this.BackColor = Color.YellowGreen;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            sayac = 0;
            this.BackColor = Color.RosyBrown;
            timer1.Stop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int dakika = 0, saniye = 0, salise = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            salise++;
            label2.Text = salise.ToString();
            if(salise == 60)
            {
                saniye++;
                label3.Text = saniye.ToString();
                saniye = 0;
            }
            if(saniye == 59)
            {
                dakika++;
                label4.Text = dakika.ToString();
                dakika = 0;
            }
        }
    }
}
