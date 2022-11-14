using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Switch_Case_Yapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("1 ile 7 arasında bir sayı giriniz:");
            sayi =Convert.ToInt32(Console.ReadLine());

            switch(sayi)
            {
                case 1: Console.WriteLine("Günlerden Pazartesi");
                    break;
                case 2: Console.WriteLine("Günlerden Salı");
                    break ;
                case 3: Console.WriteLine("Günlerden Çarşamba");
                    break;
                case 4: Console.WriteLine("Günlerden Perşembe");
                    break;
                case 5: Console.WriteLine("Günlerden Cuma");
                    break;
                case 6: Console.WriteLine("Günlerden Cumartesi");
                    break;
                case 7: Console.WriteLine("Günlerden Pazar");
                    break;
                    default: Console.WriteLine("Hatalı gün girişi");
                    break;
            }
            string mevsim;
            Console.Write("Lütfen bir mevsim giriniz:");
            mevsim = Console.ReadLine();

            switch(mevsim)
            {
                case "yaz": Console.WriteLine("Yaz mevsimi ayları:haziran temmuz ağustos");
                    break;
                case "kış": Console.WriteLine("Kış mevsimi ayları: aralık ocak şubat");
                    break;
                case "ilkbahar": Console.WriteLine("İlkbahar mevsimi ayları: mart nisan mayıs");
                    break;
                case "sonbahar": Console.WriteLine("Sonbahar mevsimi ayları: eylül ekim kasım");
                    break;
                default: Console.WriteLine("Hatalı giriş yaptıınz");
                    break;
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
