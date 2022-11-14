using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31___Sınıflar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.ADI = "Muhammed Ali";
            ogr.SOYADI = "KIR";
            ogr.YASI = 19;
            ogr.ALANI = "Sayısal";

            Console.WriteLine("Adı: "+ogr.ADI);
            Console.WriteLine("Soyadı: "+ogr.SOYADI);
            Console.WriteLine("Yaşı: "+ogr.YASI);
            Console.WriteLine("Alanı: "+ogr.ALANI);

            Console.ReadLine();
        }
    }
}
