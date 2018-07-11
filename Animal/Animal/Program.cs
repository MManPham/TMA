using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Animals
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Animal> listDog = new List<Animal>
            {
                new Dog(2,"A","Mail"),
                new Dog(3,"B","Mail"),
                new Dog(1.5,"C","FMail"),
                new Dog(2.5,"D","FMail"),

            };
            double avgAg = Animal.AvgAge(listDog);

            Console.WriteLine(avgAg);
        }
    }
}
