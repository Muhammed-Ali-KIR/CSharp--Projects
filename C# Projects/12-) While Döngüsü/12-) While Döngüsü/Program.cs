using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___While_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("*****************");

            int sayi;
            Console.Write("Bir sayı girin:");
            sayi=Convert.ToInt32(Console.ReadLine());

            while (sayi%2==0)
            {
                Console.Write("Bir sayı girin:");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tek sayı girdiniz...");

            Console.WriteLine("****************");

            int k;
            Console.Write("Faktöriyeli alınacak sayıyı giriniz:");
            k=Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;

            while (k>1)
            {
                faktoriyel = faktoriyel * k;
                k--;
            }
            Console.WriteLine(faktoriyel);




            Console.ReadLine();
        }
    }
}
