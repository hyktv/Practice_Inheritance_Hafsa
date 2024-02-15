using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance_Hafsa
{
    enum Type { boat, submarine}

    internal class Sea : Vehicle
    {
        //feild
        public Type type { get; set; }
        public Sea(Type type1, string color) : base(color)
        {
            type = type1;
        }
        public override string ToString()
        {
            return base.ToString() + $" - It is a {type}";
        }
    }
}
