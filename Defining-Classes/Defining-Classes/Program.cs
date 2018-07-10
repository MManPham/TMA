using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class MyClass
    {
        public static string function()
        {
            return "hello";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Display display = new Display(3,"sdd1212");
           Battery battery = new Battery("asdas",1000,1000);
           GSM gsm = new GSM("dfsd","sds",20000,"adfds sdsa",display,battery);
           GSM IP4S = new GSM();
           IP4S = GSM.IPhone4S();
        }
    }
}
