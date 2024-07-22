using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class Animal
    {
        //public string name;
        //public int age;

        //public Animal()
        //{
        //    name = string.Empty; // ""
        //    age = 0;
        //}

        //public Animal(string name, int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //}

        // Add one copy of static member
        public static string owner = "Tom";
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
