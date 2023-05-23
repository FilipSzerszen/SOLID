using System;

namespace MetodaSzablonowa
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfGenerator = new PdfGenerator();
            var csvGenerator = new CsvGenerator();
            var excelGenerator = new ExcelGenerator();

            pdfGenerator.GetReport();
        }
    }
}
