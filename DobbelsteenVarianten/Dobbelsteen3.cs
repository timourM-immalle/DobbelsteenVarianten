using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelsteenVarianten
{
    class Dobbelsteen3Voorbeeld
    {
        public static void Do()
        {
            Console.WriteLine("Dobbelsteen3Voorbeeld");
            Console.WriteLine("=====================");

            // Als extra moeilijkheid, maken we nu een lijst van dobbelstenen...
            var ds = new List<Dobbelsteen3>();

            ds.Add(new Dobbelsteen3(12));
            ds.Add(new Dobbelsteen3(12));
            ds.Add(new Dobbelsteen3(6));
            ds.Add(new Dobbelsteen3(6));
            //ds.Add(new Dobbelsteen3()); // Uncomment deze regel en verklaar de foutmelding!

            // We rollen met elke dobbelsteen in de lijst.
            for(var i=0; i<ds.Count; i++)
            {
                // de return-waarde negeren we...
                ds[i].Rol();
            }


            // We kunnen op de klassieke manier itereren over deze lijst:
            Console.WriteLine("Met for:");
            for (var i=0; i<ds.Count; i++)
            {
                Console.WriteLine("Dobbelsteen {0} uit de lijst heeft {1} zijden en er is {2} mee gerold", i, ds[i].AantalZijden, ds[i].Waarde);
            }

            Console.WriteLine("Met foreach:");
            // Maar er bestaat ook een handige variant v.d. for-loop.
            // Het nadeel hiervan is dat we geen index-teller hebben.
            // Het voordeel is dat we niet elke iteratie een index moeten meegeven,
            // maar gewoon telkens het volgende element uit de lijst aan een iteratie-variabele toekennen.
            foreach(var d in ds)
            {
                Console.WriteLine("De dobbelsteen uit de lijst heeft {0} zijden en er is {1} mee gerold", d.AantalZijden, d.Waarde);
            }

        }
    }

    class Dobbelsteen3
    {
        // We gebruiken nu een static random generator.
        // D.w.z. dat we - ongeacht hoeveel dobbelstenen we maken - 
        // we toch steeds maar 1 rndGen-object zullen hebben.
        // Deze static variabele `rndGen` wordt dus eigenlijk
        // gedeeld door alle objecten van deze klasse.
        static private Random rndGen = new Random();

        // `waarde` is wel nog een gewone variabele
        // en elke instantie (elk object) van deze klasse
        // zal dus zijn eigen variabele `waarde` hebben
        private int waarde;
        private int aantalZijden;

        // Met deze klasse zijn we verplicht om een
        // aantal zijden mee te geven als we een dobbelsteen maken.
        // Omdat deze constructor (met 1 parameter) aanwezig is,
        // zal de default constructor (zonder parameters) nu NIET AANWEZIG zijn!
        public Dobbelsteen3(int aantalZijden)
        {
            this.aantalZijden = aantalZijden;
        }

        public int Rol()
        {
            waarde = rndGen.Next(1, aantalZijden + 1);
            return waarde;
        }

        public int Waarde 
        {
            get
            {
                return waarde;
            }
        }

        // Het kan interessant zijn voor de gebruikers van deze klasse
        // om soms het aantalZijden op te vragen waarmee de dobbelsteen geconstrueerd werd.
        public int AantalZijden
        {
            get
            {
                return aantalZijden;
            }
        }
    }
}
