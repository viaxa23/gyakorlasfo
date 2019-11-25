using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyedikgyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //36. feladat: 
            /*Console.Write("Kérem a sorok számát: ");
            int sorok = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i + j) %2 == 0)
                    {
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write('o');
                    }
                }
                Console.WriteLine();
            }*/

            //37. feladat:

            /*Console.Write("Kérem a sorok számát: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/

            //38.feladat:

            /*Console.Write("Kérem a sorok számát: ");
            int a = Convert.ToInt32(Console.ReadLine());*/

            /*for (int i = 0; i < a; i++)
            {
                Console.SetCursorPosition(a - i, i + 1);
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/
            /*for (int i = 0; i < a; i++)

            {
                for (int k = 0; k < 20 - i; k++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/


            //39.feladat:

            /*Console.Write("Kérem a sorok számát: ");
            int sorok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i == 0) || (i == (sorok - 1)/ 2))
                    {
                        Console.Write('*');
                    }
                    else if ((j == 0) || (j == oszlopok -1) || (j == (oszlopok - 1) / 2 ))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }*/


            //41.feladat:


            /*for (int i = 65; i < 91; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
            for (int j = 66; j < 91; j++)
            {
                Console.Write((char)j);
            }
            for (int k = 65; k < 66; k++)
            {
                Console.Write((char)k);
            }*/

            for (int i = 0; i < 27; i++)
            {
                for (int j = 65 + i; j < 91; j++)
                {
                    Console.Write((char)j);
                }
                for (int k = 65; k < 65 + i; k++)
                {
                    Console.Write((char)k);
                }
                Console.WriteLine();
            }


            Console.ReadKey(true); 
        }
    }
}
