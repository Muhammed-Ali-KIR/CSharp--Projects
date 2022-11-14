using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Sınıflar_Kalıtım_4
{
    internal class Pilot
    {
        private string pilotadı;
        private string pilotsoyadı;
        private int pilotyası;
        private string pilotcinsiyeti;

        public string PİLOTADI
        {
            get { return pilotadı; }
            set { pilotadı = value.ToUpper(); }
        }
        public string PİLOTSOYADI
        {
            get { return pilotsoyadı; }
            set { pilotsoyadı = value.ToUpper(); }
        }
        public int PİLOTYASI
        {
            get { return pilotyası; }
            set { pilotyası = Math.Abs(value); }
        }
        public string PİLOTCİNSİYETİ
        {
            get { return pilotcinsiyeti; }
            set { pilotcinsiyeti = value.ToLower(); }
        }
    }
}
