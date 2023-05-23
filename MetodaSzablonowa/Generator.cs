using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{
    public abstract class Generator
    {
        public void GetReport()
        {
            GetData();
            PrepareData();
            GenerateFile();
            SendFile();
        }
        protected virtual void GetData() //void dla uproszczenia przykładu
        {
            Console.WriteLine("Base get data");
        }
        protected abstract void PrepareData();
        protected abstract void GenerateFile();
        protected void SendFile()
        {
            Console.WriteLine("Sending generated report");
        }
    }
}
