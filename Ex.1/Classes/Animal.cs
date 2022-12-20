using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1.Classes
{
    abstract class Animal
    {
        protected string name;
        protected int numOfLegs;

        public abstract string Name { get; set; }
        public abstract int NumberOfLegs { get; set; }
        
        public abstract void displayAnimal();
    }
}
