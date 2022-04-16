using System;
using D2774A_FelevesFeladat.Lists;

namespace D2774A_FelevesFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            AllergenLista<IAllergén> teszt = new AllergenLista<IAllergén>();
            teszt.Beszuras(new Tojas("teszt1"));
            teszt.Beszuras(new Tojas("teszt2"));
            teszt.Bejar(Kiir);
            
        }

        public static void Kiir(IAllergén allergen)
        {
            Console.WriteLine(allergen);
        }
    }
}
