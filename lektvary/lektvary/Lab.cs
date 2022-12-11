using System.Collections.Generic;
using System.Linq;

namespace lektvary
{
    class Lab
    { 
        public int PocetLektvaru { get; set; }
        public List<Lektvar> SeznamLektvaru { get; set; }

        public int NejCas()
        {
            List<Lektvar> list = SeznamLektvaru;
            List<Lektvar> casy = new List<Lektvar>();
            int cas = 0;

            foreach(Lektvar lek in list)
            {
                if (lek.Next == null)
                {
                    casy.Add(lek);
                }
            }

            while (list.Any())
            {
                foreach (Lektvar lektvar in list)
                {
                    if (lektvar.Previous == null || List<Lektvar>.TrueForAll(lektvar.Previous, el => el.Hotovo))
                    {
                        lektvar.Priprav();
                        list.Remove(lektvar);

                    }
                    
                   
                }
            }

            foreach(Lektvar lek in casy)
            {
                if (lek.CelkovyCas > cas)
                {
                    cas = lek.CelkovyCas;
                }
            }

            return cas;
        }
    }
}
