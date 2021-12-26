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

namespace Proje
{
    public partial class siparisEkranı : Form
    {
        public siparisEkranı()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void siparisEkranı_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kasapDataSet5.Table_2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_2TableAdapter1.Fill(this.kasapDataSet5.Table_2);
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=Kasap;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("select*from Table_2", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["urunismi"]);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        int sepetToplam;
        int vergiToplam;

        private void button1_Click(object sender, EventArgs e)
        {
            //sepete ekle butonu
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=Kasap;Integrated Security=True");
            baglanti.Open();
            string seciliUrunAd = comboBox1.Text;
            string miktar = comboBox2.Text;
            string birimfiyat;
            int fiyat;
            listBox1.Items.Add(seciliUrunAd);
            listBox2.Items.Add(miktar);
            for (int i = 0; i < 1000; i++)
            {
                SqlCommand komut = new SqlCommand("select birimfiyat from Table_2 where urunismi=@a1 and birimfiyat=@a2", baglanti);
                komut.Parameters.AddWithValue("@a1", seciliUrunAd);
                komut.Parameters.AddWithValue("@a2", i);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label10.Text = i.ToString();
                }
                dr.Close();
            }

            baglanti.Close();
            //urunun birim fiyatı secildi simdi bunu listbox3'e aktar

            birimfiyat = label10.Text;
            listBox3.Items.Add(birimfiyat);
            fiyat = Convert.ToInt32(birimfiyat) * Convert.ToInt32(miktar);
            listBox4.Items.Add(fiyat.ToString());
            sepetToplam = sepetToplam + fiyat;
            textBox2.Text = sepetToplam.ToString();
            vergiToplam = (sepetToplam * 18) / 100;
            textBox1.Text = vergiToplam.ToString();

            //buranın altı yenilemek için
            /*comboBox1.Items.Clear();
            this.table_2TableAdapter1.Fill(this.kasapDataSet5.Table_2);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //comboBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }*/



        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                //siparisi tamamla butonu
                string odemeYontemi;
                odemeYontemi = comboBox3.Text;
                if (odemeYontemi == ("Kredi Kartı"))
                {
                    odemeKredikart odemeKredikart = new odemeKredikart();
                    odemeKredikart.Show();
                    this.Hide();
                }
                if (odemeYontemi == ("Nakit"))
                {
                    MessageBox.Show("Siparişiniz Alınmıştır!");
                }
                if (odemeYontemi == ("Çek"))
                {
                    odemeCek odemeCek = new odemeCek();
                    odemeCek.Show();
                    this.Hide();
                }
                else
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaEkran anaekran = new anaEkran();
            anaekran.Show();
            this.Hide();
        }
    }
}