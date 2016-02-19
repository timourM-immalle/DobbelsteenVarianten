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

            var ds = new List<Dobbelsteen3>();

            ds.Add(new Dobbelsteen3(12));
            ds.Add(new Dobbelsteen3(12));
            ds.Add(new Dobbelsteen3(6));
            ds.Add(new Dobbelsteen3(6));
            //ds.Add(new Dobbelsteen3()); // Uncomment deze regel en verklaar de foutmelding!

            for(var i=0; i<ds.Count; i++)
            {
                ds[i].Rol();
            }

            Console.WriteLine("Met for:");
            for (var i=0; i<ds.Count; i++)
            {
                Console.WriteLine("Dobbelsteen {0} uit de lijst heeft {1} zijden en er is {2} mee gerold", i, ds[i].AantalZijden, ds[i].Waarde);
            }

            Console.WriteLine("Met foreach:");
            foreach(var d in ds)
            {
                Console.WriteLine("De dobbelsteen uit de lijst heeft {0} zijden en er is {1} mee gerold", d.AantalZijden, d.Waarde);
            }

        }
    }

    class Dobbelsteen3
    {
        static private Random rndGen = new Random();

        private int waarde;
        private int aantalZijden;

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

        public int AantalZijden
        {
            get
            {
                return aantalZijden;
            }
        }
    }
}
