using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Sınıflar_Kalıtım_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucak ucak = new Ucak();
            ucak.MARKA = "Türk Hava Yolları";
            ucak.KALKIS = "Kocaeli";
            ucak.VARİS = "İstanbul";
            ucak.ADI = "Muhammed";
            ucak.SOYADI = "KIR";
            ucak.YAS = 19;
            ucak.CİNSİYETİ = "Bay";

            Console.WriteLine("Hava yolu: "+ucak.MARKA);
            Console.WriteLine("Kalkış noktası: "+ucak.KALKIS);
            Console.WriteLine("Varış noktası: "+ucak.VARİS);
            Console.WriteLine("Yolcu adı: "+ucak.ADI);
            Console.WriteLine("Yolcu soyadı: "+ucak.SOYADI);
            Console.WriteLine("Yolcu yaşı: "+ucak.YAS);
            Console.WriteLine("Yolcu cinsiyeti: "+ucak.CİNSİYETİ);

            Console.ReadLine();
        }
    }
}
