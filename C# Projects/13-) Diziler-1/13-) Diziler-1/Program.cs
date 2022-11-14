using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Diziler_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 45, 21, 34, 41, 80, 50, 81 };
            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[7]);
            Console.WriteLine(sayilar[4]);

            Console.WriteLine("****************");

            string[] isimler = { "ali", "ahmet", "veli", "mehmet" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("****************");

            string[] sehirler = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Şehir:");
                sehirler[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.Read();
        }
    }
}
