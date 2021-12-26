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
using System.Data.Sql;


namespace Proje
{
    public partial class kayitOl : Form
    {
        public kayitOl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=Kasap;Integrated Security=True");


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.UseSystemPasswordChar = false;
            }

            if (checkBox1.Checked == false)
            {
                textBox4.UseSystemPasswordChar = true;
            }

        }

        private void kayıtOl_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
           
            musteri musteri = new musteri();
            musteri.Isim = textBox1.Text;
            musteri.Soyisim = textBox2.Text;
            musteri.KullaniciAdi = textBox3.Text;
            musteri.Sifre = textBox4.Text;
            musteri.Adres = richTextBox1.Text;


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_1 (ad,soyad,kullaniciadi,sifre,adres) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", musteri.Isim);
            komut.Parameters.AddWithValue("@p2", musteri.Soyisim);
            komut.Parameters.AddWithValue("@p3", musteri.KullaniciAdi);
            komut.Parameters.AddWithValue("@p4", musteri.Sifre);
            komut.Parameters.AddWithValue("@p5", musteri.Adres);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı!");

            musteriGiris musteriGiris = new musteriGiris();

            musteriGiris.Show();
            this.Hide();

        }

    }

}