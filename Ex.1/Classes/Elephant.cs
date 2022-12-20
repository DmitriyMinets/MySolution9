

using Ex._1.Interface;

namespace Ex._1.Classes
{
    internal class Elephant : Animal, IHerbivore, IEquatable
    {
        private string _sound;
        private string _colour;
        private int _size;

        public Elephant(string sound, string color, int size)
        {
            _sound = sound;
            _colour = color;
            _size = size;
        }

        public int Size { get { return _size; } }
        public override string Name { get => name; set => name = value; }
        public override int NumberOfLegs { get => numOfLegs; set => numOfLegs = value; }

        public override void displayAnimal()
        {
            Console.WriteLine($"Это {Name}, у него {NumberOfLegs} лапы. Он имеет {_colour} цвет и издаёт звуки типа \"{_sound}\"");
        }

        public void displayEatH()
        {
            Console.WriteLine($"{name}-{IHerbivore.typeC}. {name}-питается {IHerbivore.foodC}м.");
        }

        public void CompareTo(Elephant animal)
        {
            if (_size > animal._size)
                Console.WriteLine($"{name} больше {animal.Name} на {_size - animal.Size} ед.");
            else if (_size < animal._size)
                Console.WriteLine($"{animal.Name} больше {name} на {animal.Size - _size} ед.");
            else
                Console.WriteLine("Слоны равны");
        }
    }
}
