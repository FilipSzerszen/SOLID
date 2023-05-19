using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class ScanFasade
    {
        private QualityScanner qualityScanner = new QualityScanner();
        private SecurityScanner securityScanner = new SecurityScanner();
        private DependencyScanner dependencyScanner = new DependencyScanner();
        private ReportGenerator reportGenerator = new ReportGenerator();
        public void Scan(string githubUrl)
        {
            var qualityScanError = qualityScanner.QualityScan(githubUrl);
            var securityScanError = securityScanner.SecurityScan(githubUrl);
            var dependencyScanError = dependencyScanner.DependencyScan(githubUrl);
           reportGenerator.GenerateReport(qualityScanError, securityScanError, dependencyScanError);

        }
    }
}
