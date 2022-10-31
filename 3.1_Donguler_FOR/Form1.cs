using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1_Donguler_FOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for(i = 1; i<= 10; i++)
            {
                listBox1.Items.Add(i +". Merhaba Mucize");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 1; i<= 20; i+=2)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for(int i=0; i<10;i++)
            {
                toplam=toplam+i;
                listBox3.Items.Add(toplam);
            }
            listBox3.Items.Add("Sonuç:" + toplam);
        }
    }
}
