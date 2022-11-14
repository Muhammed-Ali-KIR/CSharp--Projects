using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___Sınıflar_Kapsülleme__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emlak  eml=new Emlak();
            eml.SEMT = "İzmit";
            eml.RENGİ = "Yeşil-Siyah";
            eml.ODASAYISI = 4;
            eml.KATNO = 41;
            eml.ALAN = 110;

            Console.WriteLine("Semti: "+eml.SEMT);
            Console.WriteLine("Rengi: "+eml.RENGİ);
            Console.WriteLine("Oda sayısı: "+eml.ODASAYISI);
            Console.WriteLine("Kat numarası: "+eml.KATNO);
            Console.WriteLine("Alanı: "+eml.ALAN + " Metrekare");

            Console.ReadLine();
        }
    }
}
