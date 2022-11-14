using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___Yıldızlarla_Şekil_Çizme_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, kenar;

            Console.Write("Kenar değerini giriniz: ");
            kenar = Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= kenar; i++)                         // satır kontrol
            {
                for (j = 1; j <= (kenar * 2 - 1); j++)      // sütun kontrol
                {
                    if (i == 1 || i == kenar)      // sadece ilk, son satırda bunu yap
                    {
                        if (j % 2 != 0)                     // sütun tek ise * koy
                            Console.Write("*");
                        else                                   // sütun çift ise boşluk koy
                            Console.Write(" ");
                    }
                    else                                // aralardaki satırlarda
                    {
                        if (j == 1 || j == (kenar * 2 - 1))     // ilk, son sütunda * koy
                            Console.Write("*");
                        else                                            // ilk, son sütun hariç aralara boşluk koy
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
