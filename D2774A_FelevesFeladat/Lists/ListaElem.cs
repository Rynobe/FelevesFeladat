using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat.Lists
{
    public class ListaElem<T>
    {
        private T aktualis;
        private ListaElem<T> kovetkezo;

        public T Aktualis { get => aktualis; }
        public ListaElem<T> Kovetkezo { get => kovetkezo; }

        public ListaElem(T aktualis, ListaElem<T> kovetkezo)
        {
            this.aktualis = aktualis;
            this.kovetkezo = kovetkezo;
        }
    }
}
