using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    interface ISound
    {
            string ProdoundSound();
    }
    class Animal:ISound
    {
        public Animal()
        {
        }

        public double age { get; private set; }
        public string name { get; private set; }
        public string sex { get; set; }

        public Animal(double age, string name, string sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

        public virtual string ProdoundSound()
        {
            return null;
        }

        public override string ToString()
        {
            return name +" - Age: "+age+" - Sex: "+sex;
        }

        public static double AvgAge(List<Animal> list)
        {
            double avgAge = list.Average(x => x.age);
            return avgAge;
        }
    }
}
