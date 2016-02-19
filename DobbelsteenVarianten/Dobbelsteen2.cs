using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelsteenVarianten
{
    class Dobbelsteen2Voorbeeld
    {
        public static void Do()
        {
            Console.WriteLine("Dobbelsteen2Voorbeeld");
            Console.WriteLine("=====================");

            var d = new Dobbelsteen2();

            Console.WriteLine(d.Rol()); // we kunnen de return-waarde nu ineens gebruiken
            Console.WriteLine(d.Rol());

            // laten we eens 10 keer rollen:
            for (var i = 0; i < 10; i++)
            {
                Console.Write(d.Rol());
                Console.Write(" ");
            }
            Console.WriteLine();

            // de laatste waarde kunnen we nog een aantal keer opvragen:
            for (var i = 0; i < 10; i++)
            {
                Console.Write(d.Waarde);
            }
            Console.WriteLine(); // nog een newline-karakter toevoegen
        }

        public static void Do2()
        {
            Console.WriteLine("Dobbelsteen2Voorbeeld met 2 dobbelstenen");
            Console.WriteLine("========================================");

            var d1 = new Dobbelsteen2();
            var d2 = new Dobbelsteen2();

            for(var i=0; i<10; i++)
            {
                d1.Rol();
                d2.Rol();
                // In de format-string wordt de som uitgelijnd op 2 karakters:
                Console.WriteLine("Dobbelsteen 1 : {0} - Dobbelsteen 2 : {1} - Som: {2,2}", d1.Waarde, d2.Waarde, d1.Waarde + d2.Waarde);
            }
        }
    }

    class Dobbelsteen2
    {
        // We initialiseren de waarde meteen, zodat we in dit geval geen constructor zelf moeten aanmaken.
        // De default-constructor (diegene zonder parameters) blijft bestaan zolang er geen enkele andere
        // constructor is aangemaakt.
        private int waarde = 0;
        private Random rndGen = new Random();
         
        // We kiezen er nu voor om de method `Rol` een `int` te laten returnen.
        // Eigenlijk hebben we dus zelfs de instantie-variabele `waarde` niet meer echt nodig,
        // behalve om ook nog de get-property te kunnen realiseren.
        public int Rol()
        {
            waarde = rndGen.Next(1, 7);
            return waarde;
        }

        // Omdat het soms nodig kan zijn om een gerolde waarde toch nog een keer uit te lezen,
        // voorzien we deze get-property.
        public int Waarde
        {
            get
            {
                return waarde;
            }
        }
    }
}
