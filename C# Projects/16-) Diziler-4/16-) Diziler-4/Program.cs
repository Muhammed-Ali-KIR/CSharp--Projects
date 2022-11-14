using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Diziler_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 26, -8, 9 };

            //foreach (int i in sayilar)
            //{
            //    if (i>0 && i%2==1)
            //    {
            //        Console.WriteLine(i);
            //    }     
            //    if (i>10 && i<30 && i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            Console.WriteLine("******************");

            int[] sayilar=new int[5];

            for (int i=0; i<5; i++)
            {
                Console.Write("Sayıyı Girin:");
                sayilar[i] =Convert.ToInt32(Console.ReadLine());
            }
            //Array.Sort(sayilar); Ne işe yarıyor?
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
