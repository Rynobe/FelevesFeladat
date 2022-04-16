using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat
{
    class Tojas : IAllergén, ITápanyag
    {
        public string Nev { get; }
        public string Reakcio { get; }
        public double Szenhidrat { get; }
        public double Feherje { get; }
        public double Zsir { get; }
        public double Rost { get; }
        public int Kaloria { get; }

        public Tojas(string nev)
        {
            this.Nev = nev;
        }
        public Tojas(string nev, string reakcio, double szenhidrat, double feherje, double zsir, double rost, int kaloria)
        {
            this.Nev = nev;
            this.Reakcio = reakcio;
            this.Szenhidrat = szenhidrat;
            this.Feherje = feherje;
            this.Zsir = zsir;
            this.Rost = rost;
            this.Kaloria = kaloria;
        }

        public override string ToString()
        {
            return Nev;
        }
    }
}
