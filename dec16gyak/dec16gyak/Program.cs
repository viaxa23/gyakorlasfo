using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec16gyak
{
    class Program
    {
        static void Main(string[] args)
        {
            int bekertSzam = 0;
            Random rnd = new Random();

            while (bekertSzam <=0)
            {
                try
                {
                    Console.Write("Adj meg egy pozitív egész számot:");
                    bekertSzam = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
           
            int[] veletlenSzamok = new int[bekertSzam];

            Console.Write("Generált számok: ");

            int osszeg = 0;
            int szorzat = 1;
            int egymasbolKivon = rnd.Next(-100, 100);
            veletlenSzamok[0] = egymasbolKivon;
            osszeg += egymasbolKivon;
            szorzat *= egymasbolKivon;
            Console.Write($"{egymasbolKivon};");

            for (int i = 0; i < bekertSzam; i++)
            {
                int generaltSzam = rnd.Next(-100, 100);
                veletlenSzamok[i] = generaltSzam;
                osszeg += generaltSzam;
                szorzat *= generaltSzam;
                egymasbolKivon -= generaltSzam;
                if (i != bekertSzam - 1)
                {
                    Console.Write($"{generaltSzam};");
                }
                else
                {
                    Console.Write(generaltSzam);
                }
             }
            Console.WriteLine($"\n\nA generált számok összege: ");
            Console.WriteLine($"A generált számok szorzata: ");

            Console.ReadKey(true);
        }
    }
}
