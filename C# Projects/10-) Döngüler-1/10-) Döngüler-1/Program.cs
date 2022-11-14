using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Döngüler_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for ( i = 0; i <=10; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }
            Console.WriteLine("******************");
            int j;
            for (j = 0; j <=10; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("******************");

            int k;
            int toplam = 0;
            for (k = 0; k <=10; k++)
            {
                toplam = toplam + k;
                Console.WriteLine(toplam);
                
            }



            Console.ReadLine();
        }
    }
}
