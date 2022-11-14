using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34___Sınıflar_Çok_Biçimlikik_5
{
    class İnsan
    {
        public virtual void selamver()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Title = "KOCAELİSPOR";
            Console.WriteLine("Merhaba Kocaelispor Taraftarları");
        }
    }

    class Türk:İnsan
    {
        public override void selamver()
        {
            Console.WriteLine("SELAMLAR");
        }
    }

    class Fransız:İnsan
    {
        public override void selamver()
        {
            Console.WriteLine("Bonjour");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Türk trk=new Türk();
            //trk.selamver();

            Fransız frans=new Fransız();
            frans.selamver();

            Console.ReadLine();
        }
    }
}
