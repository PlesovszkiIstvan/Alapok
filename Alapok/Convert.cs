using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    internal class Convert
    {
        public void csinal()
        {
            int i = 35;
            byte b = (byte)i;
            Console.WriteLine(b);
            string s = System.Convert.ToString(b);
            float szam = 30.1F;
            double d = 3.0;
            Console.WriteLine(szam + " " + d);
        }
    }
}
