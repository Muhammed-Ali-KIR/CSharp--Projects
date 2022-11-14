using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar, karealan, karecevre;
            int kisakenar, uzunkenar, dikalan, dikcevre;

            Console.WriteLine("**** Karenin Alan ve Çevresini Bulma ****");
            Console.WriteLine();
            Console.Write("Karenin kenar uzunluğunu giriniz:");
            kenar =Convert.ToInt32(Console.ReadLine());
            karealan = kenar * kenar;
            karecevre = 4 * kenar;

            Console.WriteLine("Kare alanı="+karealan);
            Console.WriteLine("Kare çevresi="+karecevre);

            Console.WriteLine("*************");
            Console.WriteLine("**** Dikdörtgenin Alan ve Çevresini Bulma");
            Console.WriteLine("Lütfen dikdörtgenin kısa kenar uzunluğunu giriniz:");
            kisakenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen dikdörtgenin uzun kenar uzunluğunu giriniz:");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            dikalan = kisakenar * uzunkenar;
            dikcevre = 2 * (kisakenar + uzunkenar);

            Console.WriteLine("Dikdörtgenin alanı:"+dikalan);
            Console.WriteLine("Dikdörtgenin çevresi:"+dikcevre);

            Console.ReadLine();

        }
    }
}
