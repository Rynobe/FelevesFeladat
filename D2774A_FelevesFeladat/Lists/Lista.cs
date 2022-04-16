using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat.Lists
{
    abstract public class Lista<T>
    {
        public delegate void BejarKezelo(T aktualis);
        public delegate bool EldontoKezelo(T aktualis);

        protected ListaElem<T> fej;
        public ListaElem<T> Fej { get;}

        public abstract void Beszuras(T ujElem);
        public abstract void Bejar(BejarKezelo metodus);
        public abstract bool Eldontes(EldontoKezelo metodus);
    }
}
