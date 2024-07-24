using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class Bird : Animal
    {
        public override string ToString()
        {
            return base.ToString() + "\nI'm bird";
        }

        public override void Move()
        {
            Console.WriteLine("I'm Flying.");
        }
    }
}
