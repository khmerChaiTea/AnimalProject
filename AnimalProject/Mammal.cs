using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    // Inherit
    internal class Mammal : Animal
    {
        public void Move()
        {
            Console.WriteLine("Mammal is moving!");
        }

        public override string ToString()
        {
            return base.ToString() + "\nI'm mammal";
        }
    }
}
