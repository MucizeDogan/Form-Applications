using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._1_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Mucize", "Doğan", "Sarıkürkcü", "İros", "Balık" };
            label1.Text = kisiler[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 3, 5, 7, 10, 4, 6, 8 };
            label2.Text = sayilar[4].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Afyonkarahisar", "Ankara", "Eskişehir", "Antalya" };
            for(int i = 0; i < sehirler.Length; i++)
            {
                listBox4.Items.Add(sehirler[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayi = { 2, 7, 9, 6, 4, 5, 3, 1 };
            for( int i = 0; i < sayi.Length; i++)
            {
                if(sayi[i]%2==0)
                {
                    listBox6.Items.Add(sayi[i]);
                }
            }
        }
    }
}
