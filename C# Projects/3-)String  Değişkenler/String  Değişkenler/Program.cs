using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace String__Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim;
            isim = "Muhammed Ali";
            Console.WriteLine(isim);

            string soyAd;
            Console.Write("Lütfen soyadınızı giriniz:");
            soyAd = Convert.ToString(Console.Read());
            Console.WriteLine("Teşekkürler...");

            Console.WriteLine("*******************");

            string ad, soyad, yas, sehir;
            Console.WriteLine("Lütfen sırasıyla ad,soyad,yaş ve şehrinizi giriniz...");

            ad = Console.ReadLine();
            soyad = Console.ReadLine();
            yas = Console.ReadLine();
            sehir = Console.ReadLine();
            Console.WriteLine("ad: " + ad);
            Console.WriteLine("soyad: " + soyad);
            Console.WriteLine("yas: " + yas);
            Console.WriteLine("sehir: " + sehir);

            Console.WriteLine("***********************");

            string takım;
            Console.Write("Lütfen takımınızı giriniz: ");
            takım = Console.ReadLine();
            Console.WriteLine("Başarılar... {0}",takım);

            Console.WriteLine("***********************");

            string iisim, soyisim;
            Console.Write("İsim: ");
            iisim = Console.ReadLine();
            Console.Write("Soyisim:");
            soyisim= Console.ReadLine();

            Console.WriteLine("İsim - Soyisim= {0} {1}",iisim,soyisim);

            Console.ReadLine();
        }
    }
}
