using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _9._1_Hastane_Proje
{
    internal class sqlbaglantisi // Sınıfımızın adı
    {
        public SqlConnection baglanti() // methodun adı
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RHMNBG1\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            // baglan--> sqlconnectiondan türettiğimiz ve adresimizi tutan nesne
            baglan.Open();
            return baglan;
        }
    }
}
