using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Diziler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i+1).ToString()+ ".Sayıyı girin:");
                sayilar[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*****************");
            int enbuyuk;
            enbuyuk= sayilar[0];

            for (int i = 1; i < 5; i++)
            {
                if (enbuyuk < sayilar[i])
                {
                    enbuyuk=sayilar[i];
                }
            }
            Console.WriteLine(enbuyuk);
            Console.ReadLine();
        }
    }
}
