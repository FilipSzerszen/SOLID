using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var builder = new InvoiceBuilder();
            //builder.SetDate(new DateTime(2023, 05,19));
            //builder.SetNumber("A1");
            //builder.SetVendor("Google");
            //builder.SetVendee("Vendee");
            //builder.SetLineItems(new List<string>() { "Line item10", "Line item2", "Line item3" });

            //Invoice invoice = builder.Build();

            var builder = new InvoiceBuilder();
            var invoice = builder.SetDate(new DateTime(2023, 05, 19))
                    .SetNumber("A1")
                    .SetVendor("Google")
                    .SetVendee("Vendee")
                    .SetLineItems(new List<string>() { "Line item10", "Line item2", "Line item3" })
                    .Build();

            Console.WriteLine(invoice.Vendor);
            Console.WriteLine(invoice.Vendee);



        }
    }
}
