using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelsteenVarianten
{
    // Om organisatorische redenen, zetten we hier een klasse `Dobbelsteen1Voorbeeld`
    // die toont hoe de klasse waar het echt om draait (`Dobbelsteen1`) moet gebruikt worden.
    class Dobbelsteen1Voorbeeld
    {
        // We noemen deze method simpelweg `Do` en maken ze static
        // zodat we geen Dobbelsteen1Voorbeeld-object moeten aanmaken
        // maar gewoon deze method kunnen aanroepen...
        //
        // De method moet public zijn om ze van buiten de class te kunnen gebruiken.
        static public void Do()
        {
            Console.WriteLine("Dobbelsteen1Voorbeeld");
            Console.WriteLine("=====================");

            Dobbelsteen1 d = new Dobbelsteen1();

            d.Rol();
            Console.WriteLine(d.Waarde);
            d.Rol();
            Console.WriteLine(d.Waarde);
            Console.WriteLine(d.Waarde);

            // Het voordeel van te werken met een aparte get-property
            // is dat we de Waarde meerdere keren kunnen gebruiken.
        }
    }

    class Dobbelsteen1
    {
        // De instantie-variabelen:
        private int waarde;
        private Random rndGen;

        // We gebruiken de constructor om een random-generator-object te maken
        public Dobbelsteen1()
        {
            rndGen = new Random();
        }

        // de methode Rol slaat een nieuwe toestand op voor de instantie-variabele `waarde`
        // maar returnt ze niet
        public void Rol()
        {
            waarde = rndGen.Next(1, 7);
        }

        // via een get-property kunnen we de Waarde uitlezen
        public int Waarde {
            get
            {
                return waarde;
            }
        }
    }
}
