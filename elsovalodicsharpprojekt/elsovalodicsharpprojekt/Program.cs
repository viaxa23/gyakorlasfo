using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsovalodicsharpprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat :
            /*string kiir = "Hello World";
            Console.WriteLine(kiir);*/

            // 2. feladat : 
            /*Console.Write("Add meg a neved");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            // 3. feladat :
            /*Console.Write("Adj meg egy számot:");
            //int szam = Int32.Parse(Console.ReadLine());
            int szam = Convert.ToInt32(Console.ReadLine());
            double szam = Double.Parse(Console.ReadLine());
            Console.WriteLine($"A szám {szam} kétszerese: {2 * szam}");*/

            //4. feladat : 
            /* Console.Write("Adj meg egy számot: ");
              int szamA = Convert.ToInt32(Console.ReadLine());
              Console.Write("Adj meg egy másik számot: ");
              int szamB = Int32.Parse(Console.ReadLine());

              int osszeg = szamA + szamB;
              int kulonbseg = szamA - szamB;
              int szorzat = szamA * szamA;
              double hanyados = szamA / szamB;

              Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
              Console.Write($"Összege {osszeg}");
              Console.Write($"Külömbsége {kulonbseg}");
              Console.Write($"Szorzata {szorzat}");
              Console.Write($"Hányadosa {hanyados}");*/

            //5. feladat : 
            /*Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB);
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
             }
            else if (szamB > szamA)
            {
                Console.WriteLine($" A kissebbik szám: {szamB}");
            }*/

            //7. feladat : 
            /*Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC =Convert.ToInt32(Console.ReadLine());

            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög szerekeszthető");
            }
            else
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög nem szerekeszthető");
            }*/

            // 8. feladat : 
            /*Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe: {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe: {mertani});
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható!");
            }*/

            //15. feladat:
            Console.WriteLine("Kérem a pozitív egész számot:  ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());
            /*string kiiratas = "";

            for (int i = 1; i < bemenoSzam; i++)
            {
                kiiratas += i + " ";
            }

            Console.WriteLine(kiiratas);

            for (int i = 1; i < bemenoSzam; i++)
            {
                Console.Write(i + " ");
            }*/

            /*int i = 1;
             Elől tesztelő ciklus
            while (i < bemenoSzam)
            {
                Console.Write(i + " ");
                //i = i + 1;
                //i += 1;
                i++;
            }*/
            /*Hátul tesztelő ciklus
            do
            {
                Console.Write(i++ + " ");
            } while (i < bemenoSzam);*/

            Console.ReadKey(true);
        }
    }
}
