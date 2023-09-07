using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    internal class Kiir
    {
        public void Kiiras()
        {
            Console.WriteLine("Egy");
            Console.WriteLine("Ketto");
        }

        public void Formating() 
        {
            string formated_string = string.Format("{0:N} xd dx xd dx {1}", 45,"szöveg");
            Console.WriteLine(formated_string);

        }
    }
}
