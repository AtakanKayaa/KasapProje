using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class adminGirisEkrani : Form
    {
        public adminGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre;
            kullaniciAdi = textBox1.Text;
            sifre = textBox2.Text;
            if (kullaniciAdi == "admin" && sifre == "123")
            {
                adminPanel adminPanel = new adminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaEkran anaEkran = new anaEkran();
            anaEkran.Show();
            this.Hide();
        }
    }
}
