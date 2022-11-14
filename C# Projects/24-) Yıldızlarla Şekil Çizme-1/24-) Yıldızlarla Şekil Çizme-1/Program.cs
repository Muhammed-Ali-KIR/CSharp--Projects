using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___Yıldızlarla_Şekil_Çizme_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                for (int j = 0; j <i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int k = 0; k < 10; k++)
            {
                for (int m = 10; m>k; m--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




            Console.ReadLine();
        }
    }
}
