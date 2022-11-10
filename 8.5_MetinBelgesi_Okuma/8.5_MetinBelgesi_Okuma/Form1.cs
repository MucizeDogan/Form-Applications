using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _8._5_MetinBelgesi_Okuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                //Akşı sağlayacak alanı openfiledialog dan açılan dosya adından al demek oluyor. Ayrıca streamreder oluşturduk
                string satir = sr.ReadLine(); //sr de okumuş olduğum satır değerlerini satir değişkenne atadım.
                while(satir!= null)
                {
                    listBox1.Items.Add(satir); //Okurken satir değerleri null boş değer olana kadar okusun.
                    satir=sr.ReadLine();
                }
            }
        }
    }
}
