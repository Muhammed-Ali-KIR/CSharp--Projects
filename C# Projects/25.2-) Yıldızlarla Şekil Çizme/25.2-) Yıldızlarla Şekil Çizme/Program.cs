using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._2___Yıldızlarla_Şekil_Çizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar;
            Console.Write("Lütfen Kenar Sayısını Giriniz:");
            kenar = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= kenar; i++)
            {
                for (int j = 1; j <= kenar; j++)
                {
                    if (i == 1 || i == kenar || j == 1 || j == kenar)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
