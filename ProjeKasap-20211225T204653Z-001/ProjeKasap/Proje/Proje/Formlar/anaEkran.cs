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
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void kAYITOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitOl kayıtOl = new kayitOl();           
            kayıtOl.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mÜŞTERİGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriGiris musteriGiris = new musteriGiris();
            musteriGiris.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kONTROLPANELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminGirisEkrani adminGirisEkrani = new adminGirisEkrani();
            adminGirisEkrani.Show();
            this.Hide();

        }
    }
}
