using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnteger_Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, toplam;
            x = 4;
            y = 1;
            toplam = x + y;
            Console.WriteLine(toplam);

            Console.WriteLine("****************");

            int a, b, c;
            a = 8;
            b = 5;
            c = a * b;
            Console.WriteLine("a*b= "+c);

            Console.WriteLine("**********");

            int deger1, deger2, bolum;
            deger1 = 12;
            deger2 = 6;
            bolum = (deger1+deger2)/2;
            Console.WriteLine(bolum);
            Console.WriteLine("**********");

            string ad, soyad, numara;
            int sınav1, sınav2, sınav3, proje,ortalama;
            Console.WriteLine("**** Ogrenci Bilgi ****");
            ad = "Muhammed Ali";
            soyad = "Kır";
            numara = "211002049";

            Console.WriteLine("Ad:"+ad);
            Console.WriteLine("Soyad:"+soyad);
            Console.WriteLine("Numara:"+numara);

            Console.WriteLine();
            Console.WriteLine("**** Not Bilgi ****");
            Console.WriteLine();

            sınav1 = 95;
            sınav2 = 65;
            sınav3 = 30;
            proje = 60;

            Console.WriteLine("Sınav1=" + sınav1);
            Console.WriteLine("Sınav2=" + sınav2);
            Console.WriteLine("Sınav3=" + sınav3);
            Console.WriteLine("Proje=" + proje);

            Console.WriteLine();
            Console.WriteLine("**** Ortalama ****");
            Console.WriteLine();

            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            Console.WriteLine("Ortalamanız:"+ortalama);

            Console.ReadLine();
        }
    }
}
