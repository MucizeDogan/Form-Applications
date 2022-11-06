using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2_Metotlar_Dondurulen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Toplama(int n1,int n2)
        {
            int n3= n1 + n2;
            return n3;
        }
        int Kup(int sayi1)
        {
            int sonuc = sayi1 * sayi1 * sayi1;
            return sonuc;
        }
        int Toplam(int s1,int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(4, 8).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);
            label3.Text=Kup(s).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox2.Text);
            int number2 = Convert.ToInt32(textBox3.Text);
            label4.Text=Toplama(number1,number2).ToString();   
        }
    }
}
