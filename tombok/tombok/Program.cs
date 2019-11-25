using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //42-43-44. feladat:
            /* Console.WriteLine("Mennyi adattal dolgozzak: ");
             int darabszam = Int32.Parse(Console.ReadLine());

             //Létrehozzuk a tömböt.
             int[] tomb = new int[darabszam];
             //Feltöltjük a tömböt egész számokkal.
             for (int i = 0; i < tomb.Length; i++)
             {
                 Console.Write($"Kérem az ({i + 1}). számot: ");
                 int szam = Int32.Parse(Console.ReadLine());
                 tomb[i] = szam;
             }

             // Megszámoljuk a páratlan tömbelemeket.
             int paratlanokSzama = 0;

             for (int i = 0; i < tomb.Length; i++)
             {
                 if (tomb[i] % 2 == 1)
                 {
                     paratlanokSzama++;
                 }
                 else
                 {
                     parosokOsszege += tomb[i];
                 }
             }
         Console.WriteLine($"A tömbben található páratlan számok száma: {paratlanokSzama}");
         //Páros számok összege.

         int parosokOsszege = 0;

         for (int i = 0; i < tomb.Length; i++)
         {
             if (tomb[i] % 2 == 0)
             {
                 parosokOsszege += tomb[i];
             }
         }

         Console.WriteLine($"A páros számok összege: {parosokOsszege}");*/
            //45feladat.

            /* Console.WriteLine("Mennyi adattal dolgozzak: ");
             int darabszam = Int32.Parse(Console.ReadLine());

             int[] tomb = new int[darabszam];

             for (int i = 0; i < tomb.Length; i++)
             {
                 Console.Write($"Kérem az ({i + 1}). számot: ");
                 int szam = Int32.Parse(Console.ReadLine());
                 tomb[i] = szam;
             }

             Console.WriteLine($"Kérem a próbaszámot: ");
             int probaSzam = Convert.ToInt32(Console.ReadLine());
             int tombIndex = -1;
             bool vanE = false;

             for (int i = 0; i < tomb.Length; i++)
             {
                 if (tomb[i] == probaSzam)
                 {
                     tombIndex = i + 1;
                     vanE = true;
                     break;
                 }
             }

             if (vanE)
             {
                 Console.WriteLine($"Találtam ilyen számot a(z) {tombIndex} pozícióban.");
             }
             else
             {
                 Console.WriteLine("Nincs ilyen szám a tömbben: ");
             }*/

            Console.WriteLine("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            Console.WriteLine($"Kérem a próbaszámot: ");
            int probaSzam = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaSzam)
                {
                    szamlalo++; 
                }

            }
            if (szamlalo != 0)
            {
                Console.WriteLine($"A(z) {probaSzam} ennyiszer szerepel: {szamlalo}");
            }
            else
            {
                Console.WriteLine("Ilyen szám nincs a tömbben. ");
            }
            Console.ReadKey(true);
        }
    }
}
