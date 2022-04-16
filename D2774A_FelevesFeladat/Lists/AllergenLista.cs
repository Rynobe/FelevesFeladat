using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2774A_FelevesFeladat.Lists
{
    public class AllergenLista<IAllergén> : Lista<IAllergén> 
    {

        public override void Beszuras(IAllergén ujElem)
        {
            
            //ListaElem<IAllergén> e = null;
            ListaElem<IAllergén> p = new ListaElem<IAllergén>(ujElem,fej);
            fej = p;

        }
        public override void Bejar(BejarKezelo metodus)
        {
            ListaElem<IAllergén> elem = fej;
            while (elem != null)
            {
                metodus?.Invoke(elem.Aktualis);
                elem = elem.Kovetkezo;
            }
        }

        public override bool Eldontes(EldontoKezelo metodus)
        {
            ListaElem<IAllergén> elem = fej;
            while (elem != null && (bool)metodus?.Invoke(elem.Aktualis))
            {
                metodus?.Invoke(elem.Aktualis);
                elem = elem.Kovetkezo;
            }
            return elem == null;
        }
    }
}
