using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelsteenVarianten
{
    class Dobbelsteen1Voorbeeld
    {
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
        }
    }

    class Dobbelsteen1
    {
        private int waarde;
        private Random rndGen;

        public Dobbelsteen1()
        {
            rndGen = new Random();
        }

        public void Rol()
        {
            waarde = rndGen.Next(1, 7);
        }

        public int Waarde {
            get
            {
                return waarde;
            }
        }
    }
}
