using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._3_Degiskenler_Int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      


        private void button2_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = Convert.ToInt32(textBox1.Text);
            alan = kenar * kenar;
            cevre = kenar * 4;
            label4.Text = alan.ToString();
            label6.Text = cevre.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kupSayi,sonuc;
            kupSayi = Convert.ToInt32(textBox2.Text);
            sonuc = kupSayi * kupSayi * kupSayi;
            label9.Text= sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, ort;
            not1 = Convert.ToInt32(textBox3.Text);
            not2 = Convert.ToInt32(textBox4.Text);
            not3 = Convert.ToInt32(textBox5.Text);
            ort = (not1+not2 +not3)/3;
            label14.Text = ort.ToString();
        }
    }
}
