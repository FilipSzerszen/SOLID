using System;

namespace Fasada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ScanFasade fasada = new ScanFasade();
            fasada.Scan("www.github.com");
        }
    }
}
