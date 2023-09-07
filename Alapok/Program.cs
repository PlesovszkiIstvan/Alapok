using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kiir kiir = new Kiir();
            MatematiCS math = new MatematiCS();
            kiir.Kiiras();
            double test = MatematiCS.pow(2,3);
            Console.WriteLine(test);
            new Kiir().Formating();
            new Convert().csinal();
            math.mathsutff();
            new Bevisz().bevisz();
            new Filekez().fileRead("C:/Users/diak/Documents/Plesovszki István/text.txt");
            Console.ReadKey();
        }
    }
}
