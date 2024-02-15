using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance_Hafsa
{
    internal class Air : Vehicle
    {
        public Air (string color) : base(color)
        {
            Color = color;
        }
    }
}
