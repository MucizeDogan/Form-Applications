using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _9._1_Hastane_Proje
{
    public partial class FrmDoktorDetay : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            // Doktor ad soyad çekme

            SqlCommand komutad = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komutad.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komutad.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text= dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //sadece kendisine ait randevuları getirme(doktorlar)

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frdb = new FrmDoktorBilgiDuzenle();
            frdb.TCNO = LblTC.Text;
            frdb.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Randevu listesinde tıklanılan randevudan şikayetin aktarılması

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Rch_Sikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
