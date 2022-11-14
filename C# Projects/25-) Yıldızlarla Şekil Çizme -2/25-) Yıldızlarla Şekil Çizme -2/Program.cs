using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___Yıldızlarla_Şekil_Çizme__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kenar Sayısı Giriniz:");
            int kare;
            kare=Convert.ToInt32(Console.ReadLine());

            //üst kenar
            for (int i = 0; i < kare; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            //sol kenar
            for (int j = 0; j < kare-2; j++)
            {
                Console.Write("*");
                for (int k = 0; k <kare-2 ; k++)
                {
                    Console.Write("  ");
                }
                //sağ kenar
                Console.Write(" *");
                Console.WriteLine();
            }
            //alt kenar
            for (int b = 0; b < kare; b++)
            {
                Console.Write("* ");
            }

            Console.ReadLine();
        }
    }
}
