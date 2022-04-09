using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat
{
    class Mogyoró : IAllergén, IEhető
    {
        public string Neve { get; set; }
        public string Reakcio { get; set; }
        public int Kalória { get; set; }
        public string ITápanyagok { get; set; }
        public string IAllergének { get; set; }

        public Mogyoró(string _neve, string _reakcio)
        {
            this.Neve = _neve;
            this.Reakcio = _reakcio;
        }
    }
}
