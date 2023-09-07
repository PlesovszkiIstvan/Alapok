using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    internal class MatematiCS
    {
        public static double pow(double x,double y)
        {
            double anws = x;
            for (int i = 0; i < y-1; i++)
            {
                anws = anws * x;
            }
            
            return anws;
        }

        public void mathsutff()
        {
            const int ALLANDO = 3;
            var rand = new Random();
            int randnum = rand.Next(ALLANDO);
            Console.WriteLine(randnum);
        }
    }
}
