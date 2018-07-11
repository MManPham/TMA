using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten:Cat
    {
        public Kitten() : base(){ sex = "Mail"; } 
        public Kitten(int age, string name,string sex):base(age,name,sex)
        {
        }
    }
}
