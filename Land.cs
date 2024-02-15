using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance_Hafsa
{
    internal class Land : Vehicle
    {
        //feild
        public int Wheels { get; set; }
        public Land(int wheels, string color) : base(color)
        {
            Wheels = wheels;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Number of Wheels: {Wheels}";
        }

    }
}
