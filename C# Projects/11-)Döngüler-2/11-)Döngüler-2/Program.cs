using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__Döngüler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 100; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("***********************");
            int sayi = 120;

            for (int j = 1; j <= 120; j++)
            {
                if (sayi % j == 0)
                {
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine("******************");
            int a = 1;
            int b = 1;
            int c = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int k = 1; k<=8; k++)
            {
                c = a + b;
                a = b;
                b = c;  
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
