using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance_Hafsa
{
    internal class Helicopter : Air
    {
        //feild
        public int NumberOfPropellers { get; set; }
        public Helicopter(int numberOfPropellers, string color) : base(color)
        {
            NumberOfPropellers = numberOfPropellers;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Number of Propellers: {NumberOfPropellers}";
        }
    }
}
