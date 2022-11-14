using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27__Metotlar_1
{
    internal class Program
    {
        private static void veriler()
        {
            Console.WriteLine("Rektör:Nedim Sözer");
            Console.WriteLine("Öğretmen:Serdar Hoca");
            Console.WriteLine("Okul:Dü");
            Console.WriteLine("Eğitsel Kol:OOP");
            Console.WriteLine("Şehir:Düzce");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        static void Main(string[] args)
        {
            veriler();
            Console.ReadLine();
        }
    }
}
