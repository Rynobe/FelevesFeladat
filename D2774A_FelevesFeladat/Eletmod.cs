using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat
{
    class Eletmod : IAllergén, ITápanyag
    {
        public string Neve { get; set; }
        public string Reakcio { get; set; }
        public double Szenhidrat { get; set; }
        public double Feherje { get; set; }
        public double Zsir { get; set; }
        public double Rost { get; set; }
        public int Kaloria { get; set; }

        public Eletmod(string _neve, string _reakcio, double _szenhidrat, double _feherje, double _zsir, double _rost, int _kaloria)
        {
            this.Neve = _neve;
            this.Reakcio = _reakcio;
            this.Szenhidrat = _szenhidrat;
            this.Feherje = _feherje;
            this.Zsir = _zsir;
            this.Rost = _rost;
            this.Kaloria = _kaloria;
        }

    }
}
