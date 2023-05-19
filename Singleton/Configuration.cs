using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Configuration
    {
        private static Configuration _instance = null;
        private static object obj = new object();
        public int IntProperty { get; set; }
        public string StringProperty { get; set; }

        private Configuration()
        {

        }
        public static Configuration GetInstance()
        {
            lock (obj)
            {
                if (_instance == null) _instance = new Configuration();
            }
            return _instance;
        }
    }
}
