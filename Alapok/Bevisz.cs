using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    internal class Bevisz
    {
        public void bevisz() 
        {
            Console.WriteLine("Kérek egy számot");
            int szam = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy másik számot");
            int szam2 = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy szövegetds");
            string szöveg = Console.ReadLine();
            Console.WriteLine("Adatok: " + szam + " | " + szam2 + " | " + szöveg);
        }

    }
}
