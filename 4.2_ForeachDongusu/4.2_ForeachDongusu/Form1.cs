using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2_ForeachDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Mucize", "Doğan", "Sarıkürkcü", "Alev" };
            foreach(string eleman in kisiler)
            {
                listBox1.Items.Add(eleman);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int ort = 0;
            int[] sinav = { 40, 70, 85, 95, 60, 80 };
            foreach(int x in sinav)
            {
                listBox3.Items.Add(x);
                toplam = toplam + x;
                label1.Text = toplam.ToString();
                ort = toplam/sinav.Length;
                label2.Text = ort.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplams = 0;
            int adet = 0;
            int[] sayilar = { 10, 20, 44, 28, 70, 4, 8, 50, 80, 33 };
            foreach(int elemans in sayilar)
            {
                listBox6.Items.Add(elemans);
                if(elemans%4==0)
                {
                    listBox5.Items.Add(elemans);
                    toplams = toplams + elemans;
                    label4.Text = toplams.ToString();
                    adet++;
                    label3.Text = adet.ToString();
                }
            }

        }
    }
}
