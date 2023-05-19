using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class CanonPrinter : IPrinter, IFax
    {

        public void Fax(string content)
        {
            Console.WriteLine("Canon print fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Canon print in Color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Canon print in Grey");
        }

    }
}
 