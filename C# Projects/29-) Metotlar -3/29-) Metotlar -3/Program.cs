using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Metotlar__3
{
    internal class Metotlar
    {
        int topla(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Metotlar metotlar = new Metotlar();
            int z;
            z = metotlar.topla(1, 3);
            Console.WriteLine("Toplam:"+z);
            Console.ReadLine();
        }
    }
}
