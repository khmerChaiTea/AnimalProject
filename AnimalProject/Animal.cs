using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class Animal
    {
        public static string owner = "Tom";
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayAnimal()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}, Owner: {Animal.owner}");
        }

    }
}
