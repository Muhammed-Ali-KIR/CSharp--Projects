using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2, toplam, fark, carpim, bolum;

            Console.WriteLine("**** Aritmetik 4 İşlem ****");

            Console.Write("Birinci sayıyı giriniz: ");
            sayı1 = Convert.ToString,Console.ReadLine();

            Console.Write("İkinci sayıyı giriniz: ");
            sayı2 = Convert.ToString,Console.ReadLine();

            toplam = sayı1 + sayı2;
            Console.WriteLine("Toplam="+toplam);

            fark = sayı1 - sayı2;
            Console.WriteLine("Fark="+fark);

            carpim = sayı1 * sayı2;
            Console.WriteLine("Çarpım="+carpim);

            bolum = sayı1 / sayı2;
            Console.WriteLine("Bölüm="+bolum);





            Console.ReadLine();
        }
    }
}
