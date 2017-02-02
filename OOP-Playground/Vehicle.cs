using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    public enum Affiliation
    {
        Rebellion, GalacticEmpire, Neutral, GalacticRepublic, Resistance, FirstOrder
    }

    class Vehicle: BaseStarWarsObject
    {

        public Vehicle()
        {
        }

        public Affiliation Affiliation { get; set; }

        public string Model { get; set; }

        public double Height { get; set; }

        public int CrewSize { get; set; }

    }
}
