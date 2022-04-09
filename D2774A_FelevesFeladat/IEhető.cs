using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat
{
    interface IEhető
    {
        public int Kalória { get; }
        public ITápanyag Tápanyagok { get; }
        IAllergén[] Allergének { get; }

        public bool Fogyaszthatja(IAllergén[] allergenek)
        {
            int i = 0;
            while (i < allergenek.Length && !VanE(allergenek[i]))
            {
                i++;
            }
            return i < allergenek.Length;
        }
        private bool VanE(IAllergén allergen)
        {
            int i = 0;
            while (i < this.Allergének.Length && allergen == this.Allergének[i])
            {
                i++;
            }
            return i < this.Allergének.Length;
        }

    }
}
