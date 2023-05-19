using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount konto = new BankAccount();
            konto.wpłać(1000);
            konto.wypłać(200);
            Console.WriteLine(konto.Balance);
        }
    }
}
