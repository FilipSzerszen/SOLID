using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class HPLaserjet : IPrinter, IFax, IScanner
    {
        public void Fax(string content)
        {
            Console.WriteLine("HP Laserjet print fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("HP Laserjet print in Color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("HP Laserjet print in Grey");
        }

        public void Scan(string content)
        {
            Console.WriteLine("HP Laserjet print Scan");
        }
    }
}
