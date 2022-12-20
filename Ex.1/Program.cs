using Ex._1.Classes;
using Ex._1.Interface;

namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat("мяу", "серый") { Name = "кот", NumberOfLegs = 4 };
            cat.displayAnimal();
            cat.displayEatC();

            Console.WriteLine(new string('-', 100));

            Elephant elephant = new Elephant("трубление", "серый", 10) { Name = "слон", NumberOfLegs = 4 };
            elephant.displayAnimal();
            elephant.displayEatH();

            Elephant elephant1 = new Elephant("трубление", "серый", 12) { Name = "слон1", NumberOfLegs = 4 };
            elephant.displayAnimal();
            elephant.displayEatH();

            Console.WriteLine(new string('-', 100));

            Bear bear = new Bear("рык", "чёрный") { Name = "медведь", NumberOfLegs = 4 };
            bear.displayAnimal();
            bear.displayEatH();
            bear.displayEatC();

            Console.WriteLine(new string('-', 100));

            Animal[] animals = new Animal[6] { elephant, elephant1, cat, elephant, cat, bear};

            Zoo zoo = new Zoo(animals);

            zoo.ShowPaddockCarnivore();
            zoo.ShowPaddockHerbivore();

            Console.WriteLine(new string('-', 100));

            elephant.CompareTo(elephant);
            

        }

    }
}