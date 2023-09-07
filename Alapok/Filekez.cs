using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Alapok
{
    internal class Filekez
    {
        public void fileRead(string path)
        {
            if (File.Exists(path))
            { 
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                while (line != null) {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }
    }
}
