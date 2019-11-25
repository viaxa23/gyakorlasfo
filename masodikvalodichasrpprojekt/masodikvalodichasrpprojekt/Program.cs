using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikvalodichasrpprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1-100 ig azok a számok melyek valódi osztóinak összege osztható 7-tel. ");
            for (int i = 1; i < 101; i++)
            {
                if (osszeghettel(i))
                {
                    Console.WriteLine($"{i} ");
                }
            }

            int szam = 0;

            while (szam <=0)
            {
                Console.WriteLine($"Kérek egy egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }

            if (osszeghettel(szam))
            {
                Console.WriteLine($"{szam} valódi osztóinak száma osztható 7-tel. ");
            }

            else
            {
                Console.WriteLine($"{szam} valódi osztóinak száma nem osztható 7-tel. ");
            }

            Console.ReadKey(true);
            
        }

        static bool PrimszamE(int szam)
        {
            bool primE = true;
            int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;

            for (int i = 0; i < hatar; i++)
            {
                if (szam % i == 0)
                {
                    primE = false;
                    break;
                }
            }
        }
