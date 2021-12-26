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
    public partial class adminUrunEkleCikart : Form
    {
        public adminUrunEkleCikart()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=Kasap;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=Kasap;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunum urunum = new urunum();

            urunum.ürünismi= textBox1.Text;
            urunum.miktar = Convert.ToInt32(textBox2.Text);
            urunum.birimfiyat = Convert.ToInt32(textBox3.Text);
            urunum.vergimiktari = Convert.ToInt32(comboBox1.Text);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_2 (urunismi,miktar,birimfiyat,vergimiktari) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", urunum.ürünismi);
            komut.Parameters.AddWithValue("@p2", urunum.miktar);
            komut.Parameters.AddWithValue("@p3", urunum.birimfiyat);
            komut.Parameters.AddWithValue("@p4", urunum.vergimiktari);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi");



        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand sil = new SqlCommand("delete from Table_2 where urunismi=@isim", baglanti);

            sil.Parameters.AddWithValue("@isim", comboBox2.Text);

            sil.ExecuteNonQuery();
            baglanti.Close();

            this.table_2TableAdapter1.Fill(this.kasapDataSet2.Table_2);

            MessageBox.Show("Ürün Başarıyla Çıkarıldı.");

        }

        private void adminUrunEkleCikart_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kasapDataSet2.Table_2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_2TableAdapter1.Fill(this.kasapDataSet2.Table_2);
            // TODO: Bu kod satırı 'kasapDataSet1.Table_2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_2TableAdapter.Fill(this.kasapDataSet1.Table_2);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox2.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.table_2TableAdapter1.Fill(this.kasapDataSet2.Table_2);
            comboBox2.Items.Clear();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox2.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            adminPanel.Show();
            this.Hide();

        }
    }
}
