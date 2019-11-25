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

            Console.Write("Kérem a sorok számát: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.SetCursorPosition(a - i, i + 1);
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
                Console.ReadKey(true); 
        }
    }
}
