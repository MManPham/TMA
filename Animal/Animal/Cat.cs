using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Animal
    {
        public Cat()
        {
        }

        public Cat(int age, string name, string sex) : base(age, name, sex)
        {

        }



        public override string ProdoundSound() => "Meo Meo";
    }
}
