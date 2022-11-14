using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___Sınıflar_Kapsülleme__3
{
     class Emlak
    {
        public string semt;
        private string renk;
        private int odasayi;
        private int katno;
        private double alan;

        public string SEMT
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string RENGİ
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }
        public int ODASAYISI
        {
            get { return odasayi; }
            set { odasayi = Math.Abs(value); }
        }
        public int KATNO
        {
            get { return katno; }
            set { katno= Math.Abs(value); }
        }
        public double ALAN
        {
            get { return alan; }
            set { alan= Math.Abs(value); }
        }
    }
}
