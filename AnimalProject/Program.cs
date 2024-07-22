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
            t1.Name = "Test";
            t1.Age = 1;
            Console.WriteLine($"Name: {t1.Name}, Age: {t1.Age}");

            var t2 = new Animal { Name="Test2", Age=5 };
            Console.WriteLine($"Name: {t2.Name}, Age: {t2.Age}");
        }
    }
}
