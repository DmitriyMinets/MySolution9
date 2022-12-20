using Ex._1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1.Interface
{
    internal interface IEquatable
    {
        public int Size { get; }
        void CompareTo(Elephant animal);
    }
}
