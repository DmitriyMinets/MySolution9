using Ex._1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1.Classes
{
    internal class Zoo
    {
        private List<Animal> _paddockCarnivore = new List<Animal>();
        private List<Animal> _paddockHerbivore = new List<Animal>();

        public Zoo(Animal[] animal)
        {

            for (int i = 0; i < animal.Length; i++)
            {
                if (animal[i] is ICarnivore)
                    _paddockCarnivore.Add(animal[i]);
                else
                    _paddockHerbivore.Add(animal[i]);
            }
        }

        public List<Animal> PaddockCarnivore { get { return _paddockCarnivore; } }
        public List<Animal> PaddockHerbivore { get { return _paddockHerbivore; } }


        public void ShowPaddockCarnivore()
        {
            Console.Write("Загон с плотоядными животными: ");
            foreach (Animal item in _paddockCarnivore)
            {
                Console.Write(item.Name + " ");
            }
            Console.WriteLine();
        }

        public void ShowPaddockHerbivore()
        {
            Console.Write("Загон с травоядными животными: ");
            foreach (Animal item in _paddockHerbivore)
            {
                Console.Write(item.Name + " ");
            }
            Console.WriteLine();
        }
    }
}
