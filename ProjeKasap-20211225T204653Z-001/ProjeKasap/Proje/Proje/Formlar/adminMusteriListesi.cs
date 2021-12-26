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
    public partial class adminMusteriListesi : Form
    {
        public adminMusteriListesi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaEkran anaEkran = new anaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void adminMusteriListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kasapDataSet.Table_1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.kasapDataSet.Table_1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
