using Ex._1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1.Classes
{
    internal class Cat : Animal, ICarnivore
    {
        private string _sound;
        private string _colour;

        public Cat(string sound, string color)
        {
            _sound = sound;
            _colour = color;
        }

        public override string Name { get => name; set => name = value; }
        public override int NumberOfLegs { get => numOfLegs; set => numOfLegs = value; }

        public override void displayAnimal()
        {
            Console.WriteLine($"Это {Name}, у него {NumberOfLegs} лапы. Он имеет {_colour} цвет и издаёт звуки типа \"{_sound}\"");
        }

        public void displayEatC()
        {
            Console.WriteLine($"{name}-{ICarnivore.typeC}. {name}-питается {ICarnivore.foodC}м.");
        }
    }
}
