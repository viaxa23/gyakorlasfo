using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember ember = new Ember(181, 85, "1998.02.15");
            Ember emberke = ember;
            //emberke.LekerMagassag() = 145;
            Console.WriteLine($"Az ember magassága: {ember.LekerMagassag()} cm");
            Console.WriteLine($"Az ember testsúlya: {ember.LekerTestsuly()} kg");
            Console.WriteLine($"Az ember születési éve: {ember.LekerSzuletesiEv()}");
            Console.WriteLine($"Az ember magassága: {emberke.LekerMagassag()} cm");
            Console.WriteLine($"Az ember testsúlya: {emberke.LekerTestsuly()} kg");
            Console.WriteLine($"Az ember születési éve: {emberke.LekerSzuletesiEv()}");
            Console.ReadKey(true);
        }
    }
    class Ember
    {
       private int magassag;
       private int testsuly;
       private string szuletesiEv;

        public Ember(int Magassag, int Testsuly, string SzuletesiEv)
        {
            this.magassag = Magassag;
            this.testsuly = Testsuly;
            this.szuletesiEv = SzuletesiEv;
        }

        public int LekerMagassag()
        {
            return this.magassag;
        }

        public int LekerTestsuly()
        {
            return this.testsuly;
        }

        public string LekerSzuletesiEv()
        {
            return this.szuletesiEv;
        }
    }
}
