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
            /*Console.WriteLine("Kérem a pozitív egész számot:  ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());*/
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

            //16. feladat

            /*Console.WriteLine("Kérem a pozitív egész számot:  ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());
            string kiiratas = "";*/

            /*for (int i = 1; i < bemenoSzam; i++)
            {
                kiiratas += i + "\n";  // \n jelöli a sortörést!
            }

            Console.WriteLine(kiiratas);*/

            /*for (int i = 1; i < bemenoSzam; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 1;
             //Elől tesztelő ciklus
            while (i < bemenoSzam)
            {
                Console.Write(i++);
                //i = i + 1;
                //i += 1;
                i++;
            }*/
            //Hátul tesztelő ciklus
            /*int i = 1;
            do
            {
                Console.WriteLine(i++);
            } while (i < bemenoSzam);*/

            //17. feladat
            /*Console.WriteLine("Kérem a pozitív egész számot:  ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());*/

            /*for (int i = 0; i <= bemenoSzam; i++)
            {
                if (bemenoSzam % i==0)
                {
                    Console.WriteLine(i);
                }
            }*/

            // Plusz feladat: Pozitív szám prím-e?

            /*Console.WriteLine("Kérem a pozitív egész számot:  ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());

            int szamlalo = 0;
            int osztokOsszege = 0;

            for (int i = 1; i < bemenoSzam + 1; i++)
            {
                if (bemenoSzam % i ==0)
                {
                    szamlalo++;
                    osztokOsszege += i;
                }
            }
            if (szamlalo == 2)
            {
                Console.WriteLine($"A bemenő szám {bemenoSzam} prím.");
                Console.WriteLine($"A bemenő szám {bemenoSzam} osztóinak összege: {osztokOsszege}");
            }
            else
            {
                Console.WriteLine($"A bemenő szám {bemenoSzam} nem prím");
                Console.WriteLine($"A bemenő szám {bemenoSzam} osztóinak összege: {osztokOsszege}");
            }*/
            //19. feladat: 
            /*Console.WriteLine("Kérem a pozitív egész számot:  ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());

            int osztokOsszege = 0;

            int i = 1;

            while (i <= bemenoSzam)
            {
                if (bemenoSzam % 1 == 0)
                {
                    osztokOsszege += 1;
                }
                i++;
            }
            if (osztokOsszege == 2 * bemenoSzam)
            {
                Console.WriteLine($"A szám {bemenoSzam} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"A szám {bemenoSzam} nem tökéletes szám." );
            }*/

            //20. feladat:
            /* int alap = -1;
             while (alap < 0 || alap >= 10)
             {
                 Console.WriteLine("Kérem az alapot:  ");
                 int alap = Int32.Parse(Console.ReadLine());
             }
             int kitevo = -1;
             while (kitevo < 0 || alap >= 10)
             {
                 Console.WriteLine("Kérem a kitevőt:  ");
                 int kitevo = Int32.Parse(Console.ReadLine());
                 int kitevo = -1; 
             Console.WriteLine("Kérem a kitevőt:  ");
             int kitevo = Int32.Parse(Console.ReadLine());
             int hatvany = 1;

             for (int i = 0; i < kitevo; i++)
             {
                 hatvany *= alap;
             }
             Console.Write($"hatvány: {hatvany}");*/

            //21. feladat:
            /*int szam = 0;

            while (szam <=0)
            {
                Console.Write($"Kérek egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            // Plusz feladat: Prímszámra lépjen ki a ciklusból

            /*int szam = 3;

            while (primSzamE(szam))
            {
                Console.Write($"Kérek egy nem prímszámot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/
            //22. feladt: 
            int szam = 11;

            int osszeg = 0;

            while (szam <= 10)
            {
                Console.WriteLine($"Kérek egy 10-nél kisebb egész számot: ");
                szam = Int32.Parse(Console.ReadLine())
                osszeg += szam;
            }
            Console.WriteLine($"Az eddig beolvasott számok összeg: {osszeg}.");
            
    
            Console.ReadKey(true);
        }
        static bool primSzamE(int szam)
        {
            bool teljesul = true;

            int osztokSzama = 0;

            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osztokSzama++;
                }
             
            }
            if (osztokSzama == 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }
        }
    }
}
