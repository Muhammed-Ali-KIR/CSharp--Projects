using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28___Metotlar_2
{
    internal class Program
    {
        private static void yazdir(string bilgi)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bilgi);
            }
        } 
        private static int Topla(int s1,int s2)
        {
            int t =s1+ s2;
            return t;
        }
        private static int Çıkar(int s3,int s4)
        {
            int k = s3 - s4;
            return k;
        }
        private static int kupu(int sayi)
        {
            int j = sayi * sayi * sayi;
            return j;
        }
        static void Main(string[] args)
        {
            Console.Write("Metni girin:");
            string blg=Console.ReadLine();
            yazdir(blg);
            Console.WriteLine("****************");
            Console.WriteLine();

            Console.WriteLine("Toplam:"+Topla(5,8));
            Console.WriteLine("Toplam:" + Topla(41,81));
            Console.WriteLine("****************");
            Console.WriteLine();

            Console.WriteLine("Fark:"+Çıkar(41,34));
            Console.WriteLine("Fark:" + Çıkar(81,41));
            Console.WriteLine("****************");
            Console.WriteLine();

            Console.WriteLine("Küpü:"+kupu(5));
            Console.WriteLine("Küpü:"+kupu(3));
            Console.Read();
        }
    }
}
