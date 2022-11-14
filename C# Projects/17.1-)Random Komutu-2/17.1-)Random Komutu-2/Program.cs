using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._1__Random_Komutu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("**** Şehir Atama Programı ****");
            string[] sehirler = { "kocaeli", "sakarya", "bursa", "izmir", "istanbul" };
            int a;
            a=random.Next(0,sehirler.Length);
            Console.WriteLine(a);
            Console.WriteLine(sehirler[a]);
            Console.ReadLine(); 
        }
    }
}
