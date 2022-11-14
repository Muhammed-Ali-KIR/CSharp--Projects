using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Sınıflar_Kalıtım_4
{
     class Yolcu
    {
        private string ad;
        private string soyad;
        private int yas;
        private string cinsiyet;

        public string ADI
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public string CİNSİYETİ
        {
            get { return cinsiyet; }
            set { cinsiyet = value.ToLower();}
        }       
    }
}
