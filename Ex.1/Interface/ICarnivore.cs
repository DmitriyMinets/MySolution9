using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1.Interface
{
    internal interface ICarnivore //Хищник
    {
        static string typeC = "хищник";
        static string foodC = "мясо";

        void displayEatC();
    }
}
