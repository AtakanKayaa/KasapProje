using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    class musteri
    {
        private string isim;
        private string soyisim;
        private string adres;
        private string kullaniciAdi;
        private string sifre;

        public string Isim 
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value.ToUpper() ; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
