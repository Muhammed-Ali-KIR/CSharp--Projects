using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Çok_Boyutlu_Diziler__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Matrislerde Toplama *****\n");
            int[,] matris1 = { { 32, 12, 42, 16 }, { 21, 22, 34, 27 } };
            int[,] matris2 = { { 10, 11, 12, 13 }, { 22, 23, 24, 31 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(matris1[i, j] + matris2[i, j] + " ");
                Console.WriteLine("\n");
            }
            Console.Read();
        }
    }
}
