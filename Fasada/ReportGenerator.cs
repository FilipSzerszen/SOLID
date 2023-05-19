using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class ReportGenerator
    {
        public void GenerateReport(IEnumerable<string> qualityScanErrors,
                                    IEnumerable<string> securityScanError,
                                    IEnumerable<string> dependencyScanError)
        {
            Console.WriteLine("qualityScanErrors");
            Console.WriteLine(string.Join("  ", qualityScanErrors));

            Console.WriteLine("securityScanError");
            Console.WriteLine(string.Join("  ", securityScanError));

            Console.WriteLine("dependencyScanError");
            Console.WriteLine(string.Join("  ", dependencyScanError));

        }
    }
}
