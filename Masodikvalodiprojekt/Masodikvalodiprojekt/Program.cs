using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodikvalodiprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int szam = 0;
               Console.WriteLine("Kérek két számot: ");
               //bool egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
              // Console.WriteLine($"A bekért szám: {szam}");
               do
               {
                   Console.Write("Kérek egy számot: ");
                    egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
               } while (egeszSzam);
               Console.WriteLine($"A bekért szám: {szam}");
            string kimenet = "";
            Console.Write("kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            kimenet += szam " = ";

            while (szam % 2 == 0)
            {
                kimenet += 2 + " * ";
                szam = szam / 2;
            }

            kimenet += szam;*/

            //25. feladat: 
            /*string kimenet = "";

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            kimenet += szam + " = ";
            int egesz = 0;
            int tort = szam;

            while (szam - 3 > 0)
            {
                szam = szam - 3;
                egesz++;
                tort = szam;
      
            }

            kimenet += egesz + " * 3 + " + tort;

            Console.WriteLine(kimenet);*/

            //24. feladat:

            /* string alma = "";

             while (alma == "alma")
             {
                 Console.WriteLine("Kérek egy gyümölcsöt: " );
                 alma = Console.ReadLine();
             }

             Console.WriteLine("Az alma egy gyümölcs! ");*/

            //28-29. feladat: 

            /*string kimenet = "";

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            kimenet += szam + " = ";

            int meddig = (int)(Math.Floor(Math.Sqrt(szam))) + 1;

            for (int i =2; i < meddig; i++)
            {

                if (szam % i == 0)
                {
                    if (szam == 1)
                    {
                        kimenet += 1;
                    }
                    else
                    {
                        kimenet += i + " * ";
                        szam = szam / i;
                        i--;
                    }
                    
                }
            }

            kimenet += szam;
            Console.WriteLine(kimenet);*/

            //32. feladat
            /*Console.WriteLine("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{szam} * {i} = {szam * i} ");
            }*/

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < szam; i++)
            {
                for (int j = 1; j < szam + 1; j++)
                {
                    Console.SetCursorPosition(3 * (j - 1) + 1, i);
                    Console.Write($"()")
                }
            }
            

            Console.ReadKey(true);
        }
    }
}
