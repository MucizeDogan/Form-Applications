using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._7_Ornek_ProgressBar_Tımer_PastaPisirmeSurec_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
                MessageBox.Show("Karıştırıldı!");
            }
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.White;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Red;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
                MessageBox.Show("Çırpıldı!");
            }
            if (progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Red;
            }
            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.White;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
                MessageBox.Show("Eklendi!");
            }
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.White;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Red;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 20;
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Pastamız Hazır!");
            }
            if (progressBar4.Value % 40 == 20)
            {
                label4.BackColor = Color.Red;
            }
            if (progressBar4.Value % 40 == 0)
            {
                label4.BackColor = Color.White;
            }
        }
    }
}
