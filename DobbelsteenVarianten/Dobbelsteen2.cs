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

            Console.WriteLine(d.Rol());
            Console.WriteLine(d.Rol());

            for (var i = 0; i < 10; i++)
            {
                Console.Write(d.Rol());
                Console.Write(" ");
            }
            Console.WriteLine();

            for (var i = 0; i < 10; i++)
            {
                Console.Write(d.Waarde);
            }
            Console.WriteLine();
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
                Console.WriteLine("Dobbelsteen 1 : {0} - Dobbelsteen 2 : {1} - Som: {2,2}", d1.Waarde, d2.Waarde, d1.Waarde + d2.Waarde);
            }
        }
    }

    class Dobbelsteen2
    {
        private int waarde = 0;
        private Random rndGen = new Random();
        
        public int Rol()
        {
            waarde = rndGen.Next(1, 7);
            return waarde;
        }

        public int Waarde
        {
            get
            {
                return waarde;
            }
        }
    }
}
