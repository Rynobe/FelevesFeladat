using D2774A_FelevesFeladat.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat
{
    class Mogyoró : IAllergén, IEhető
    {
        public string Nev { get; }
        public string Reakcio { get; }
        public int Kalória { get; }
        public string ITápanyagok { get; }
        public string IAllergének { get; }
        public ITápanyag[] Tápanyagok { get; }
        public AllergenLista<IAllergén> Allergének { get; }

        public Mogyoró(string nev, string reakcio)
        {
            this.Nev = nev;
            this.Reakcio = reakcio;
        }
    }
}
