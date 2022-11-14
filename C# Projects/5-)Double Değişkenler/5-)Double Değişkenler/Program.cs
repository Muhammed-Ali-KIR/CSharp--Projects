using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Double_Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Öğrenci Not Hesaplama ******");

            double sınav1, sınav2, proje, ortalama;
            string ad ,soyad, numara;
            Console.WriteLine();
            Console.WriteLine("****Öğrenci Kimlik Bilgileri****");
            Console.WriteLine();

            Console.Write("Adınız:");
            ad=Console.ReadLine();

            Console.Write("Soyadınız:");
            soyad=Console.ReadLine();

            Console.Write("Numaranız:");
            numara=Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("**** Öğrenci Not Bilgileri ****");
            Console.WriteLine();
            Console.Write("Sınav1=");
            sınav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sınav2=");
            sınav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Proje notu=");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("**** Ortalama Değeri ****");
            Console.WriteLine();

            ortalama = (sınav1 + sınav2 + proje) / 3;
            Console.Write("Ortalama:"+ortalama);


            Console.ReadLine();
        }
    }
}
