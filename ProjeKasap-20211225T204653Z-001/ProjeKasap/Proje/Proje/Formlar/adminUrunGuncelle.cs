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
    public partial class adminUrunGuncelle : Form
    {
        public adminUrunGuncelle()
        {
            InitializeComponent();
        }

        private void adminUrunGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kasapDataSet3.Table_2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_2TableAdapter.Fill(this.kasapDataSet3.Table_2);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=Kasap;Integrated Security=True");



        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Table_2 Set miktar=@a1,birimfiyat=@a2,vergimiktari=@a3 where urunismi=@a4", baglanti);

            guncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@a2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@a3", textBox3.Text);
            guncelle.Parameters.AddWithValue("@a4", comboBox1.Text);
            guncelle.ExecuteNonQuery();
            this.table_2TableAdapter.Fill(this.kasapDataSet3.Table_2);

            baglanti.Close();
            MessageBox.Show("Ürün bilgisi başarıyla güncellendi!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenurun;

            secilenurun = comboBox1.Text;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string datadegeri = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (datadegeri==secilenurun)
                {
                    textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                }

            }
            this.table_2TableAdapter.Fill(this.kasapDataSet3.Table_2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
