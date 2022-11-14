using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___İf_Else_Yapısı_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.Write("Lütfen bir mevsim giriniz:");
            mevsim = Console.ReadLine();

            if (mevsim=="kış")
            {
                Console.WriteLine("Kış ayları:aralık,ocak,şubat");
            }
            else if (mevsim=="yaz")
            {
                Console.WriteLine("Yaz ayları:haziran,temmuz,ağustos");
            }
            else if (mevsim=="sonbahar")
            {
                Console.WriteLine("Sonbahar ayları:eylül,ekim,kasım");
            }
            else if(mevsim=="ilkbahar")
            {
                Console.WriteLine("İlkbahar ayları:mart,nisan,mayıs");
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
            }
            Console.WriteLine("**************************");

            Console.WriteLine("**** NİKE ****");
            int x, indirim, odenecek;
            Console.Write("Alışveriş tutarını giriniz:");
            x=Convert.ToInt32(Console.ReadLine());

            if (x<100)
            {
                indirim = x * 10 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Toplam miktar:"+odenecek);
            }
            if (x>=100 && x<150)
            {
                indirim = x * 20 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Toplam miktar:"+odenecek);
            }
            if (x >= 150 && x < 200)
            {
                indirim = x * 30 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Toplam miktar:" + odenecek);
            }
            if (x >= 200 )
            {
                indirim = x * 50 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Toplam miktar:" + odenecek);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
