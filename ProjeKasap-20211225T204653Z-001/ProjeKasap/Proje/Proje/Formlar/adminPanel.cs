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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            anaEkran anaEkran = new anaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminUrunEkleCikart adminUrunEkleCikart = new adminUrunEkleCikart();
            adminUrunEkleCikart.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminMusteriListesi adminMusteriListesi = new adminMusteriListesi();
            adminMusteriListesi.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            adminUrunGuncelle adminUrunGuncelle = new adminUrunGuncelle();
            adminUrunGuncelle.Show();
            this.Hide();
        }
    }
}
