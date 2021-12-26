using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    class urunum
    {
        public string ürünismi;
        public int miktar;
        public int birimfiyat;
        public int vergimiktari;

        public void hesapla()
        {
            float tutar = (this.miktar * this.birimfiyat) * (this.vergimiktari / 100);

          
        }


    }
}