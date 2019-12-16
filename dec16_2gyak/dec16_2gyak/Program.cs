using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec16_2gyak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alapösszeg: ");
            double osszeg = Double.Parse(Console.ReadLine());
            double alapOsszeg = osszeg;
            Console.Write("Kamatláb: ");
            double kamat = Double.Parse(Console.ReadLine());
            Console.Write("Futamidő: ");
            int futamido = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.SetCursorPosition(14, 4);
            Console.Write("Évenkénti összeg");

            for (int i = 0; i < futamido; i++)
            {
                osszeg = (kamat / 100 + 1) * osszeg;
                Console.SetCursorPosition(14, 5 + i);
                Console.WriteLine($"\n{i + 1}. év végén: {osszeg:F0}Ft");
                Console.Write($"{osszeg - alapOsszeg:F0}Ft");
            }


            Console.ReadKey(true);
        }
    }
}
