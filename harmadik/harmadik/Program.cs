using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadik
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("A párosan speciális számok: ");
              for (int i = 10; i < 100; i++)
              {
                  int kulsoTizes = 1 / 10;
                  int kulsoEgyes = 1 % 10;
                  for (int j = 10; j < 100; j++)
                  {
                      int belsoTizes = j / 10;
                      int belsoEgyes = j % 10;
                      int belsoSzorzat = i * j;
                      int kulso = 10 * kulsoEgyes + kulsoTizes;
                      int belso = 10 * belsoEgyes + belsoTizes;
                      int kulsoSzorzat = kulso * belso;
                      if (belsoSzorzat == kulsoSzorzat)
                      {
                          Console.WriteLine($"Az {i} és {j} párosan speciális számok: ");
                      }
                  }
              }*/
            int sorok = 5;
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 97; j < sorok; j++)
                {
                    if (97 + i + j * sorok < 123)
                    {
                        Console.SetCursorPosition(i * 10, 0);
                        Console.WriteLine($"{(char) (97 + i + j * sorok)} {97 + i + j * sorok}");
                    }
                    
                }
            }

            Console.ReadKey(true);
        }
    }
}
   /* static bool primszamE(int szam)
    {
        bool teljesul = true;
        int osztokszama = 0;
        for (int i = 1; i <= szam; i++)
        {
            if (szam % i == 0)
                osztokszama++;
        }
        if ( osztokszama == 2)
        {
            return teljesul;
        }
        else
        {
            return teljesul;
        }
    }*/

