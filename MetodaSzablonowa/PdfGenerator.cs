using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{
    public class PdfGenerator : Generator
    {
        protected override void GetData()
        {
            Console.WriteLine("Overrided PDF getData()");
        }
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate PDF file");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for pdf");
        }
    }
}
