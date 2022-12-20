using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1.Interface
{
    internal interface IHerbivore //Травоядное
    {
        static string typeC = "травоядное";
        static string foodC = "частями деревьев или различными растениями";

        void displayEatH();
    }
}
