using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Random_Komutu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random rastgele = new Random();
            //int a;
            //a=rastgele.Next(0,10);
            //Console.Write(a);

            //Random random = new Random();
            //int a, b;
            //a = random.Next(0, 10);
            //b = random.Next(0, 10);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            

            Random random = new Random();
            int sayi;
            sayi = random.Next(50); //parantezin içi boş bırakılırsa tanımlanan değişkenin türünden rastgelede değer alır
            Console.WriteLine(sayi);
            Console.ReadLine();
        }
    }
}
