using System;
using System.Linq;


namespace lektvary
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocetLektvaru = int.Parse(Console.ReadLine());
            int pocetZavislosti = int.Parse(Console.ReadLine());
            string cas = Console.ReadLine();
            int[] casy = Array.ConvertAll(cas.Split(),s => int.Parse(s));
            (int, int)[] zavislosti = new (int, int)[pocetZavislosti];

            for (int i = 0; i <pocetLektvaru; i++)
            {
                string radka = Console.ReadLine();

                zavislosti[i].Item1 = int.Parse(radka.Split()[0]);
                zavislosti[i].Item2 = int.Parse(radka.Split()[1]);

            }

        }
    }
}
