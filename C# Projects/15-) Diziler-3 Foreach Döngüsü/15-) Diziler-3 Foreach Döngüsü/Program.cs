using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _15___Diziler_3_Foreach_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = {"Mersin","İzmir","Kocaeli","Artvin","Ankara","Erzurum","Şanlıurfa"};

            foreach (string i in sehirler)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");

            int[] sayilar = { 1, 4, 8, 41, 52, 75, 126, 85, 24 };
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
