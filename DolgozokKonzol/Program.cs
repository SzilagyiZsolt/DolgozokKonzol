using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozokKonzol
{
    internal class Program
    {
        static Adatbazis db = new Adatbazis();
        static List<Dolgozo> dolgozok;
        static void Main(string[] args)
        {
            dolgozok = db.getAllDolgozok();
            feladat01();
            feladat02();
            feladat03();
            feladat04();
            Console.WriteLine("Program vége");
            Console.ReadLine();
        }

        private static void feladat04()
        {
            //Kilistázza az "asztalosműhely"-ben dolgozók nevét
            Console.WriteLine("4. feladat");
            foreach (var dolgozo in dolgozok.Where(x => x.reszleg == "asztalosműhely"))
            {
                Console.WriteLine($"\t{dolgozo.nev}");
            }
        }

        private static void feladat03()
        {
            //Hányan dolgoznak az egyes részlegeken
            Console.WriteLine("3. feladat");
            foreach (var dolgozo in dolgozok.GroupBy(a => a.reszleg).Select(b => new {reszleg = b.Key, letszam = b.Count()}).OrderBy(x => x.letszam))
            {
                Console.WriteLine($"\t{dolgozo.reszleg} - {dolgozo.letszam} fő");
            }
        }

        private static void feladat02()
        {
            //A legmagasabb keresetű dolgozó neve 
            int maxber =dolgozok.Max(x => x.ber);
            Dolgozo dolgozo = dolgozok.Find(x => x.ber == maxber);
            Console.WriteLine("2. feladat");
            Console.WriteLine($"\tA legnagyobb bérrel rendelkező ember: {dolgozo.nev}");
        }

        private static void feladat01()
        {
            //Kiírja a dolgozók számát
            Console.WriteLine("1. feladat");
            Console.WriteLine($"\tA dolgozók száma: {dolgozok.Count} fő!");
        }
    }
}
