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
            Console.WriteLine(t1);

            var t2 = new Animal { Name="Test2", Age=5 };
            Console.WriteLine(t2);

            var t3 = new Mammal();
            t3.Move();
            Console.WriteLine(t3);
        }
    }
}
