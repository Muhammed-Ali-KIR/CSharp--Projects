using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//c# tür     .NET yapısı    en küçük           en büyük
//sbyte       System.Sbyte   -128                127
//byte        System.byte    0                   255
//short       System.Int16
//ushort      System.UInt16
//int         System.Int32
//uint        System.UInt32
//long        System.Int64   
//ulong       System.UInt64


namespace _4__Aritmetik_4_işlem_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2, toplam;

            Console.WriteLine("**** Toplama İşlemi ****");
            Console.Write("Birinci sayıyı giriniz: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            sayı2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayı1 + sayı2;
            Console.WriteLine("Toplam = "+toplam);




            Console.ReadLine();
        }
    }
}
