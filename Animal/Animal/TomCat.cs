using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class TomCat:Cat
    {
        public TomCat() : base() => sex = "Mail";
        public TomCat(int age, string name, string sex) : base(age, name, sex)
        {
           
        }
    }
}
