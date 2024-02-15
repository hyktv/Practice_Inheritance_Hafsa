using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance_Hafsa
{
    internal class Plane : Air
    {
        //feild
        public int NumberOfJets { get; set; }
        public Plane(int numberOfJets, string color) : base(color)
        {
            NumberOfJets = numberOfJets;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets: {NumberOfJets}";
        }

    }
}
