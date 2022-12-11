using System;
using System.Linq;
using System.Collections.Generic;

namespace lektvary
{
    class LabDef
    {
        public static Lab Nacti(int pocetLektvaru, int pocetZavislosti, int[] casy, (int,int)[] zavislosti)
        {
            Lab lab = new Lab();
            lab.PocetLektvaru = pocetLektvaru;

            for (int i = 0; i < pocetLektvaru; i++)
            {
                Lektvar lek = new Lektvar(casy[i]);
                lab.SeznamLektvaru.Add(lek);
            }

            foreach((int,int) zavislost in zavislosti)
            {
                lab.SeznamLektvaru[zavislost.Item1].Next.Add(lab.SeznamLektvaru[zavislost.Item2]);
                lab.SeznamLektvaru[zavislost.Item2].Previous.Add(lab.SeznamLektvaru[zavislost.Item1]);
            }

            return lab;
        }
    }
}
