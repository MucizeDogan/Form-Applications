using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1_If_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            isim = textBox1.Text;
            if (isim == "Ali")
            {
                label2.Text = isim + " Bey Hoşgeldiniz";
                MessageBox.Show(isim + " Bey Hoşgeldiniz");
            }
            else
            {
                label2.Text = "Yanlış Giriş";
                MessageBox.Show("Yanlış Giriş");
            }
            
                
          
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi=Convert.ToInt32(textBox2.Text);
            if(sayi==5)
            {
                label4.Text = sayi + " Sayısı Doğru";
            }
            else
            {
                label4.Text = sayi + " Sayısı YANLIŞ!";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(textBox3.Text);
            if (sayi1 %2==0)
            {
                label6.Text = "ÇİFT";
            }
            else
            {
                label6.Text = "TEK";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi2=Convert.ToInt32(textBox4.Text);
            if (sayi2 >= 10 && sayi2 % 2 == 0)
            {
                label7.Text = "Girilen" + sayi2 + " sayısı 10'dan BÜYÜK ve ÇİFT ";
            }
            else if(sayi2 >= 10 && sayi2 % 2 == 1)
            {
                label7.Text = "Girilen" + sayi2 + " sayısı 10'dan BÜYÜK ve TEK ";
            }
            else
            {
                label7.Text = "Girilen" + sayi2 + " sayısı 10'dan Küçük ve Tek ";
            }
        }
    }
}
