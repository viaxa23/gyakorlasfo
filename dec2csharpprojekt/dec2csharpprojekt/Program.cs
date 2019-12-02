using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec2csharpprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //54.feladat.
            /*Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();

            for (int i = szo.Length - 1; i >=0; i--)
            {
                Console.Write(szo[i]);
            }*/

            //55.feladat

            /*Console.Write("Kérek egy mondatot: ");
            string mondat = Console.ReadLine();*/

            /* for (int i = 0; i < mondat.Length; i++)
             {
                 if ((int)mondat[i] !=32)
                 {
                     Console.Write(mondat[i]);
                 }
                 else
                 {
                     Console.WriteLine();
                 }
             }*/

            /*string[] tomb = mondat.Split(' ');

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }*/

            //56.feladat

            /*Console.Write("Adj meg egy szót: ");
            string szo = Console.ReadLine();
            string forditottSzo = "";

            for (int i = szo.Length - 1; i <= 0; i++)
            {
                forditottSzo += szo[i];
            }

            Console.WriteLine(forditottSzo.ToUpper());*/

            /*Console.Write("Kérek egy mondatot: ");
            string mondat = Console.ReadLine());

            string[] tomb = mondat.Split(' ');

            for (int i = 0; i < tomb.Length; i++)
            {
                string elsoBetu = tomb[i].Substring(0, 1).ToUpper();
                string maradek = tomb[i].Substring(1);
                Console.WriteLine(elsoBetu + maradek);
            }*/

            //56. feladat (MINDEN MÁSODIK BETŰT VÁLTOZTASSA MEG NAGYRA)

            /*Console.Write("Kérek egy mondatot: ");
            string mondat = Console.ReadLine());

            string[] tomb = mondat.Split(' ');

            for (int i = 0; i < tomb.Length; i++)
            {
                if (i % 2 == 1)
                {

                }
            }*/

            //Plusz feladat: Adott szóban minden második betű nagybetű.
            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            string kiir = " ";

            for (int i = 0; i < szo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char ch = (char)((int)szo[i] - 32);
                    kiir += ch;
                }
                else
                {
                    kiir += szo[i];
                }
            }

            Console.ReadKey(true);
        }
    }
}
