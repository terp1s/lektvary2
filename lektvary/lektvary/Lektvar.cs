using System.Collections.Generic;
using System.Linq;
using System;

namespace lektvary
{
    class Lektvar
    {
        public int Cas { get; private set; }
        public int CelkovyCas { get; set; }
        public List<Lektvar> Previous {get; set; }
        public List<Lektvar> Next { get; set; }
        public bool Hotovo = false;

        public Lektvar(int cas)
        {
            Cas = cas;
        }

        public void Priprav()
        {
            Hotovo = true;
            int prevMax = (from l in Previous select l.Cas).Max();
            CelkovyCas = Cas + prevMax;
        }
    }
}
