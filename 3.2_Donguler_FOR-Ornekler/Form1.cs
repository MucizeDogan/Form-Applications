using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2_Donguler_FOR_Ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i= 1; i <= 10; i++)
            {
                if(i%3==0)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
         int sayi = Convert.ToInt32(textBox1.Text);
            for(int i= 1; i <= sayi; i++)
            {
                listBox2.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayix = Convert.ToInt32(textBox2.Text);
            for(int i= 1; i <= sayix; i++)
            {
                if(sayix%i==0)
                {
                    listBox3.Items.Add(i.ToString());
                }
            }
        }
    }
}
