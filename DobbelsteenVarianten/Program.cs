using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelsteenVarianten
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dit programma demonstreert 3 verschillende Dobbelsteen-classes:
            // `Dobbelsteen1`, `Dobbelsteen2` en `Dobbelsteen3`.
            // In een echt programma zou je natuurlijk maar 1 soort dobbelsteen maken
            // en die gewoon `Dobbelsteen` noemen.

            // Om organisatorische redenen, demonstreren we het gebruik van elke dobbelsteen
            // in een aparte static method.
            Dobbelsteen1Voorbeeld.Do();
            Dobbelsteen2Voorbeeld.Do();
            Dobbelsteen2Voorbeeld.Do2();
            Dobbelsteen3Voorbeeld.Do();
        }
    }
}
