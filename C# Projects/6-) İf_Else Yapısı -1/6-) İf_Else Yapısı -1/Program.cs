using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___İf_Else_Yapısı__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sınav1, sınav2,ort;
            Console.Write("Lütfen sınav1'i giriniz:");
            sınav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen sınav2'i giriniz:");
            sınav2 = Convert.ToInt32(Console.ReadLine());

            ort = (sınav1 + sınav2) / 2;
            Console.WriteLine("Ortalama= "+ort);


            if (ort>=50)
            {
                Console.WriteLine("Tebrikler Geçtiniz...");
            }
            else
            {
                Console.WriteLine("Kaldınız...Tekrar Deneyiniz...");
            }

            Console.WriteLine("************************");
            string sehir;
            Console.WriteLine("Türkiyenin Başkenti Neresidir?");
            sehir = Console.ReadLine();

            if (sehir=="Ankara")
            {
                Console.WriteLine("Tebrikler... Doğru Bildiniz");
            }
            else
            {
                Console.WriteLine("Yanlış cevap... Tekrar Deneyiniz");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
