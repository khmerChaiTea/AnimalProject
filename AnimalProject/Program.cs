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
            t1.DisplayAnimal();

            var t2 = new Animal { Name="Test2", Age=5 };
            t2.DisplayAnimal();
        }
    }
}
