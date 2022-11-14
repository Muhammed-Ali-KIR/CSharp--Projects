using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35___Ref_Out_Kullanımı
{
     class Program
    {
        static void arttir(out int s)
        {
            s = 12;
            s++;
        }
        static void Main(string[] args)
        {
            int a;
            arttir(out a);
            Console.WriteLine(a);
            Console.Read();
        }
    }
}
