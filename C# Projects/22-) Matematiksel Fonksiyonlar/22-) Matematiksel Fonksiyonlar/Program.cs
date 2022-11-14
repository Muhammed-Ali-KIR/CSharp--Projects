using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Matematiksel_Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Mutlak Değer ****");
            //Mutlak Değer
            int sayi;
            Console.Write("Sayiyi girin:");
            sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mutlak Değerli Hali: " +Math.Abs(sayi));
            Console.WriteLine();
            

            Console.WriteLine("**** Üste Yuvarlama ****");
            //Sayıyı Üste Yuvarlama
            double sayi1;
            Console.Write("Sayi 1'i giriniz:");
            sayi1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayının Üste Yuvarlanmış Hali:"+ Math.Ceiling(sayi1));
            Console.WriteLine();
            

            Console.WriteLine("***** Alta Yuvarlama ****");
            //Sayıyı Alta Yuvarlama
            double sayi2;
            Console.Write("Sayi 2'i giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayının Alta Yuvarlanmış Hali:" + Math.Floor(sayi2));
            Console.WriteLine();
            

            Console.WriteLine("**** Üs Alma ****");
            //Sayının Üssünü Alma
            double sayi3;
            Console.Write("Sayi 3'ü giriniz:");
            sayi3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sonuç:" + Math.Pow(sayi3 , 5));
            Console.WriteLine();
            

            Console.WriteLine("**** Karekök Alma****");
            //Karekök Alma
            double sayi4;
            Console.Write("Sayi 4'ü giriniz:");
            sayi4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sonuç:"+Math.Sqrt(sayi4));
            Console.WriteLine();

            //Max,Min
            double s1, s2;
            Console.Write("Birinci sayıyı giriniz:");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Büyük sayı="+Math.Max(s1,s2));
            Console.Write("Küçük sayı="+Math.Min(s1,s2));

            Console.ReadLine();
        }
    }
}
