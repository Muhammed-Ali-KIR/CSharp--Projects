using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Çok_Boyutlu_Diziler_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            Console.Write("Satır Sayısı girin:");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun Sayısı girin:");
            sutun = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("Matrisin {0} x {1} Degeri: ", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int k = 0; k < satir; k++)
            {
                for (int m = 0; m < sutun; m++)
                {
                    Console.Write(matris[k, m] + " ");
                }
                Console.WriteLine();
            }
            //Transpoze
            Console.WriteLine("**** Matrisin Transpozesi *****");

            for (int x = 0; x < sutun; x++)
            {
                for (int y = 0; y < satir; y++)
                {
                    Console.Write(matris[y, x] + " ");
                }
                Console.WriteLine();
            }
            // Kat sayı çarpımı
            Console.WriteLine("**** Matris Katsayı Çarpımı ****");

            int carpim;
            Console.Write("Lütfen Katsayıyı girin:");
            carpim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int s = 0; s < satir; s++)
            {
                for (int ş = 0; ş < sutun; ş++)
                {
                    Console.Write(matris[s, ş] * carpim + " ");
                }
                Console.WriteLine();
            }
            // determinant
            int determinant = Math.Abs(matris[0, 0] * matris[1, 1]) - (matris[1, 0] * matris[0, 1]);
            Console.WriteLine("determinant of matrix = " + determinant);
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
