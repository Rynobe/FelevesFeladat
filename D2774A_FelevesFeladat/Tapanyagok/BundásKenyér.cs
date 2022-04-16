using D2774A_FelevesFeladat.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat
{
    class BundásKenyér : IEhető
    {
        public int Kalória { get; }

        public ITápanyag[] Tápanyagok { get; }

        public AllergenLista<IAllergén> Allergének { get; }

        public BundásKenyér(int kaloria, ITápanyag[] tapanyag, AllergenLista<IAllergén> allergen)
        {
            this.Kalória = kaloria;
            this.Tápanyagok = tapanyag;
            this.Allergének = allergen;
        }

    }
}
