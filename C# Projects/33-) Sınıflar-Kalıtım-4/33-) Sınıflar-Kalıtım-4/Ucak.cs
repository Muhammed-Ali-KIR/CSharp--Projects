using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Sınıflar_Kalıtım_4
{
     class Ucak:Yolcu
    {
        private string marka;
        private string kalkıs;
        private string varis;

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
        public string KALKIS
        {
            get { return kalkıs; }
            set { kalkıs = value.ToLower(); }
        }
        public string VARİS
        {
            get { return varis; }
            set { varis = value.ToUpper(); }
        }

    }
}
