using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megyek
{
    class Program
    {
        static void Main(string[] args)
        {
            Megye [] megyek = new Megye;
            for (int i = 0; i < megyek.Length; i++)
            {
                Console.Write("Kérem a megye nevét:");
                string nev = Console.ReadLine();
                Console.Write("Kérem a megye területét:");
                int terulet = Int32.Parse(Console.ReadLine());
                Console.Write("Kérem a megye székhelyét:");
                string megyeszekhely = Console.ReadLine();
                Console.Write("Nyugat-Magyarországi-e:");
                bool keletiE = Boolean.Parse(Console.ReadLine());
                megyek[i] = new Megye(nev, terulet, megyeszekhely, keletiE);
            }
            for (int i = 0; i < megyek.Length; i++)
            {
                megyek[i].KiirAdatok();
            }



            NyugatMagyarorszagiMegye nyMegye = new NyugatMagyarorszagiMegye(nev, terulet, megyeszekhely, nyugatiE); 
            nyMegye.KiirAdatok();

            Console.ReadKey(true);
        }
    }

    class Megye
    {
       public string Nev { get; set; }
        public int Terulet {get; set;}
        public string Megyeszekhely { get; set;}

        public bool KeletMagyarorszagiE { get; set; }

        public Megye(string nev, int terulet, string megyeSzekhely)
        {
            this.Nev = nev;
            this.Terulet = terulet;
            this.Megyeszekhely = megyeSzekhely;
            

        }

        public Megye(string nev, int terulet, string megyeSzekhely, bool keletiE) : 
        {
            this.Nev = nev;
            this.Terulet = terulet;
            this.Megyeszekhely = megyeSzekhely;
            this.KeletMagyarorszagiE = keletiE;

        }
        public void KiirAdatok()
        {
            if (this.KeletMagyarorszagiE)
            {
                Console.WriteLine($"A megye neve: {this.Terulet} és megyeszékhelye: {this.Megyeszekhely}.");
            }
            
        }
    }
    class NyugatMagyarorszagiMegye : Megye
    {
        public bool NyugatMagyarorszagiE { get; set; }

        public NyugatMagyarorszagiMegye(string nev, int terulet, string megyeSzekhely, bool nyugatiE) : base(nev, terulet, megyeSzekhely)
        {
            this.NyugatMagyarorszagiE = nyugatiE;
        }

        new public void KiirAdatok()
        {
            if (this.NyugatMagyarorszagiE)
            {
                Console.WriteLine($"A megye neve: {this.Nev} megye, terület, megyeszékhely");
            }
        }
    }

}
