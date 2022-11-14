using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___Zaman_Fonksiyonları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman;
            zaman = DateTime.Now;
            Console.WriteLine("Tarih ve Saat: {0}", zaman);

            Console.WriteLine("*****************");

            DateTime zaman2;
            zaman2 = DateTime.Now;
            int ay = zaman.Month;
            int gün = zaman.Day;
            int yıl = zaman.Year;
            DayOfWeek haftanıngünü = zaman.DayOfWeek;
            Console.WriteLine("Gün:{0}",gün);
            Console.WriteLine("Ay:{0}",ay);
            Console.WriteLine("Yıl:{0}",yıl);
            Console.WriteLine("Haftanın günü:{0}",haftanıngünü);
            Console.WriteLine("*****************");

            DateTime zaman3;
            zaman3=DateTime.Now;
            Console.WriteLine("**** C# Dersleri Tarih Saat Fonksiyonları ****");
            Console.WriteLine();
            Console.WriteLine("Kısa Tarih:{0:d}",zaman3);
            Console.WriteLine("Uzun Tarih:{0:D}",zaman3);
            Console.WriteLine("Tam Tarih:{0:f}",zaman3);
            Console.WriteLine("Tam Tarih2:{0:F}", zaman3);
            Console.ReadLine();
        }
    }
}
