using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Animal();
            t1.name = "Test";
            t1.age = 1;
            Console.WriteLine($"Name: {t1.name}, Age: {t1.age}");

            var t2 = new Animal("Test2", 5);
            Console.WriteLine($"Name: {t2.name}, Age: {t2.age}");
        }
    }
}
