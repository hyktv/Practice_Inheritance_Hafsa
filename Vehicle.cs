using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance_Hafsa
{
    internal class Vehicle
    {
        //feild
        public string color;

        //constructor and property
        public string Color { get; set; }
        public Vehicle(string color)
        {
            Color = color;
        }
        public override string ToString()
        {
            return $"{this.GetType()} Color - {Color}";
        }

    }
}
