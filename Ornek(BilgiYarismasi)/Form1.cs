using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._5_if_else_Ornek_BilgiYarismasi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label6.Text = btnB.Text;

            if (label4.Text == label6.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                MessageBox.Show(label4.Text);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label6.Text = btnC.Text;

            if (label4.Text == label6.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                MessageBox.Show(label4.Text);
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label6.Text = btnD.Text;

            if (label4.Text == label6.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                MessageBox.Show(label4.Text);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label6.Text = btnA.Text;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            if (label4.Text == label6.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                MessageBox.Show(label4.Text);
            }

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruNo++;
            lblSoruNo.Text = soruNo.ToString();

            btnSonraki.Enabled = false;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            label7.Visible = false;
            richTextBox1.Enabled = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if(soruNo ==1)
            {
                richTextBox1.Text = "Aşağıda Verilen İlk Çağ Uygarlıklarından Hangisi Yazıyı İcat Etmiştir?";
                    
                btnA.Text = "A:      Sümerler";
                btnB.Text = "B:      Hititler";
                btnC.Text = "C:      Urartular";
                btnD.Text = "D:      Finikeliler";
                label4.Text ="A:      Sümerler";
            }
            if(soruNo ==2)
            {
                richTextBox1.Text = "Aşağıdakilerden Hangisi Dünya Sağlık Örgütünün Kısaltılmış İsmidir? ?";
                btnA.Text = "A:      UHF";
                btnB.Text = "B:      UNICEF";
                btnC.Text = "C:      WHO";
                btnD.Text = "D:      NATO";
                label4.Text = "C:     WHO";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Simgesi ( Ca ) olan elementin adı nedir?";
                btnA.Text = "A:      Azot";
                btnB.Text = "B:      Kalsiyum";
                btnC.Text = "C:      Çinko";
                btnD.Text = "D:      Krom";
                label4.Text = "B:      Kalsiyum";
            }
            if(soruNo==4)
            {
                richTextBox1.Text = "İzafiyet teorisi kime aittir?";
                btnA.Text = "A:      Albert Einstein";
                btnB.Text = "B:      Isaac Newton";
                btnC.Text = "C:      Nikola Tesla";
                btnD.Text = "D:      Galileo";
                label4.Text = "A:      Albert Einstein";
                
                
            }
            if(soruNo==5)
            {
                richTextBox1.Text = "Nobel'e aday gösterilen ilk yazarımız hangisidir?";
                btnA.Text = "A:      Ziya Paşa";
                btnB.Text = "B:      Kemal Tahir";
                btnC.Text = "C:      Orhan Kemal";
                btnD.Text = "D:      Yaşar Kemal";
                label4.Text = "D:      Yaşar Kemal";
            }
            if(soruNo==6)
            {
                richTextBox1.Text = "Oğuz Kağan Destanı kime aittir?";
                btnA.Text = "A:      Hititler";
                btnB.Text = "B:      Hunlar";
                btnC.Text = "C:      Uygurlar";
                btnD.Text = "D:      Göktürkler";
                label4.Text = "B:      Hunlar";
                
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "158 kıtalık dünyanın en uzun milli marşı hangi ülkeye aittir?";
                btnA.Text = "A:      Yunanistan";
                btnB.Text = "B:      Hindistan";
                btnC.Text = "C:      Japonya";
                btnD.Text = "D:      Kamboçya";
                label4.Text = "A:      Yunanistan";
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Türkiye'nin en yüksek kalelerinden biri olma ünvanına sahip olan tarihi Karahisar Kalesi'nden Afyonkarahisar manzarasını seyretmek isteyen birisi kaleye ulaşmak için kaç merdiven çıkmalıdır?";
                btnA.Text = "A:      999";
                btnB.Text = "B:      868";
                btnC.Text = "C:      701";
                btnD.Text = "D:      626";
                label4.Text = "C:      701";
            }
            if (soruNo ==9)
            {
                richTextBox1.Text = "SON SORU! Türkiye'nin yüzölçümü en büyük komşusu hangisidir?";
                btnA.Text = "A:      Suriye";
                btnB.Text = "B:      İran";
                btnC.Text = "C:      Irak ";
                btnD.Text = "D:      Azarbeycan";
                label4.Text = "B:      İran";
                btnSonraki.Text = "Sonuç Mesajı";

            }
            if (soruNo==10)
            {
                btnSonraki.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Bilgi Yarışmamız sona ermiştir.");

            }
        }
    }
}
