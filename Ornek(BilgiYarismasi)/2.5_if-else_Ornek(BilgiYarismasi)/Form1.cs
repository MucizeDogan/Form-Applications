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
                richTextBox1.Text = "İrem Salcı - Mucize Doğan Sarıkürkçü ilişkisinde hangi taraf diğerine göre daha çok seviyor?";
                    
                btnA.Text = "A:      Mucize Doğan Sarıkürkcü";
                btnB.Text = "B:      İrem Salcı";
                btnC.Text = "C:      Eşit";
                btnD.Text = "D:      O hiç aşık olmamış ki nerden bilsin :;))";
                label4.Text ="A:      Mucize Doğan Sarıkürkcü";
            }
            if(soruNo ==2)
            {
                richTextBox1.Text = "Mucize İrem'e ilk Whatsaap mesajını hangi tarihte yazmıştır :;) ?";
                btnA.Text = "A:      03.11.2020";
                btnB.Text = "B:      12.11.2020";
                btnC.Text = "C:      01.12.2020";
                btnD.Text = "D:      16.12.2020";
                label4.Text = "C:      01.12.2020";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Mucize Doğan Sarıkürkcü'nün en sevdiği şarkı hangisidir? EN DİYORUM ENN";
                btnA.Text = "A:      Leyla The Band-Yalan";
                btnB.Text = "B:      Athena-Ben Böyleyim";
                btnC.Text = "C:      Tepki-Rüyalar";
                btnD.Text = "D:      Çağrı Ergün-Parçalandım";
                label4.Text = "B:      Athena-Ben Böyleyim";
            }
            if(soruNo==4)
            {
                richTextBox1.Text = "Mucize Doğan en çok nereye girmeyi sever? (İrem'de)";
                btnA.Text = "A:      Am";
                btnB.Text = "B:      Göt";
                btnC.Text = "C:      Ağız";
                btnD.Text = "D:      Meme";
                label4.Text = "B:      Göt";
                btnSonraki.Text = "Sonuç Mesajı";
                
            }
            if(soruNo==5)
            {
                btnSonraki.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Umarım cevapların hepsi Doğrudur İROS ;:;)))))");

            }
        }
    }
}
