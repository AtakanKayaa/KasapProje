using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proje
{
    public partial class musteriGiris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public musteriGiris()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            musteri musteri = new musteri();

            musteri.KullaniciAdi = textBox1.Text;

            musteri.Sifre = textBox2.Text;

            con = new SqlConnection("Data Source =DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog = Kasap;Integrated Security = True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select*from table_1 where kullaniciadi='" + musteri.KullaniciAdi + "'And sifre='" + musteri.Sifre + "'";

            dr = com.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("TEBRİKLER GİRİŞ BAŞARILI");
                siparisEkranı siparisEkranı = new siparisEkranı();
                siparisEkranı.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI GİRİS YAPTİNİZ.LÜTFEN TEKRAR DENEYİNİZ.");

            }
            con.Close();



        }
    }
}
