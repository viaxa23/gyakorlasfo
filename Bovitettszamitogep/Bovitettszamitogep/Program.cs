﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovitettszamitogep
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Kérem az első számot: ");
                int elso = Int32.Parse(Console.ReadLine());
                Szam elsoSZam = new Szam(elso);
                Console.WriteLine("Kérem a második számot: ");
                int masodik = Int32.Parse(Console.ReadLine());
                Szam masodikSZam = new Szam(masodik);
                Console.WriteLine("Kérem a harmadik számot: ");
                int harmadik = Int32.Parse(Console.ReadLine());
                Szam harmadikSZam = new Szam(harmadik);

                elsoSZam.ElsoKetSzamOsszege(masodikSZam);
                elsoSZam.ElsoKetSzamKulonbsege(masodikSZam);
                elsoSZam.ElsoKetSzamSzorzata(masodikSZam);
                elsoSZam.ElsoKetSzamHanyadosa(masodikSZam);
                elsoSZam.ElsoKetSzamMertaniKozepe(masodikSZam);
                elsoSZam.SzamokSzamtaniKozepe(masodikSZam, harmadikSZam);
                elsoSZam.SzamokMertaniKozepe(masodikSZam, harmadikSZam);
            }
            catch (Exception e)
            {

                throw;
            }
            Console.ReadKey(true);
        }

        class Szam
        {
            // Ez itt a propertybe ágyazott private mezőérték.
            public int BekertErtek { get; set;}

            // Egy argumentumos konstruktor.
            public Szam(int bekert)
            {
                this.BekertErtek = bekert;
            }

            public void ElsoKetSzamOsszege(Szam szam)
            {
                Console.WriteLine($"Az első két szám összege: {this.BekertErtek + szam.BekertErtek}");
            }

            public void ElsoKetSzamKulonbsege(Szam szam)
            {
                Console.WriteLine($"Az első két szám különbsége: {this.BekertErtek - szam.BekertErtek}");
            }

            public void ElsoKetSzamSzorzata(Szam szam)
            {
                Console.WriteLine($"Az első két szám szorzata: {this.BekertErtek * szam.BekertErtek}");
            }

            public void ElsoKetSzamHanyadosa(Szam szam)
            {
                if (szam.BekertErtek != 0)
                {
                    Console.WriteLine($"Az első két szám hányadosa: {(double)this.BekertErtek / szam.BekertErtek}");
                }
                else
                {
                    Console.WriteLine($"Az első két szám hányadosa nem véges érték.");
                }
                
            }

            public void ElsoKetSzamMertaniKozepe(Szam szam)
            {
                if (szam.BekertErtek >= 0 && this.BekertErtek >= 0 )
                {
                    Console.WriteLine($"Az első két szám mértani közepe: {Math.Sqrt(this.BekertErtek * szam.BekertErtek)}");
                }
                else
                {
                    Console.WriteLine($"Az első két számból legalább az egyik negatív érték.");
                }
            }

            public void SzamokSzamtaniKozepe(Szam szam, Szam masikSzam)
            {
                Console.WriteLine($"A számok számtani közepe: {((double)this.BekertErtek + szam.BekertErtek + masikSzam.BekertErtek)/3 :F3}");
            }

            public void SzamokMertaniKozepe(Szam szam, Szam masikSzam)
            {
                double ertek = Math.Exp(Math.Log(this.BekertErtek * szam.BekertErtek * masikSzam.BekertErtek) / 3);
                Console.WriteLine($"A számok mértani közepe(első): {Math.Pow((this.BekertErtek + szam.BekertErtek + masikSzam.BekertErtek),(double) 1/3):F3}");
                Console.WriteLine($"A számok mértani közepe(második):{ertek:F6}");
            }
        }
    }
}
