using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30___Sınıflar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba arbsnf = new Araba();
            arbsnf.model = "2016";
            arbsnf.renk = "Siyah";
            arbsnf.fiyat = 150000;
            arbsnf.vites = "Otomatik";
            arbsnf.plaka = "41 MK 041";
            

            Console.WriteLine("Araba Modeli: " + arbsnf.model);
            Console.WriteLine("Araba Rengi: " + arbsnf.renk);
            Console.WriteLine("Araba Fiyatı: " + arbsnf.fiyat);
            Console.WriteLine("Araba Vitesi: " + arbsnf.vites);
            Console.WriteLine("Araba Plakası: " + arbsnf.plaka);

            Console.WriteLine("******************");

            arbsnf.model = "2022";
            arbsnf.renk = "Beyaz";
            arbsnf.fiyat = 450000;
            arbsnf.vites = "Otomatik";
            arbsnf.plaka = "41 MAK 041";

            Console.WriteLine("Araba Modeli: " + arbsnf.model);
            Console.WriteLine("Araba Rengi: " + arbsnf.renk);
            Console.WriteLine("Araba Fiyatı: " + arbsnf.fiyat);
            Console.WriteLine("Araba Vitesi: " + arbsnf.vites);
            Console.WriteLine("Araba Plakası: " + arbsnf.plaka);




            Console.ReadLine();

        }
    }
}
