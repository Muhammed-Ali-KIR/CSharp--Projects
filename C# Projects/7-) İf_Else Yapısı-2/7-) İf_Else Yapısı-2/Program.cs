using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___İf_Else_Yapısı_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sınav1, sınav2, proje, ortalama;
            Console.Write("1.sınavı giriniz:");
            sınav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.sınavı giriniz:");
            sınav2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Proje notunu giriniz:");
            proje = Convert.ToInt32(Console.ReadLine());

            ortalama = (sınav1 + sınav2 + proje) / 3;
            Console.WriteLine("Ortalama:" + ortalama);

            if (ortalama >= 50)
            {
                Console.WriteLine("Öğrenci dersi geçti...");
            }
            else
            {
                Console.WriteLine("Öğrenci dersten kaldı...");
            }
            Console.WriteLine("*****************");

            int sayi;
            Console.Write("Lütfen sayıyı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çift sayıdır");
            }
            else
            {
                Console.WriteLine("Girilen sayı tek sayıdır");
            }

            Console.ReadLine();
        }
    }
}
