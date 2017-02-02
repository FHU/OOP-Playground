using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    public enum PlanetType {Desert, Forest, Gas, Ice, Swamp }
    
    class Planet : BaseStarWarsObject
    {
        public Planet()
        {
            NumberOfPlanets++;
        }

        public static Planet CreateTatooine()
        {
            return new Planet() { Name = "Tatooine", Diameter = 5.3, Type = PlanetType.Desert };
        }

        public string Name { get; set; }
        public double Diameter { get; set; }

        // Desert, Forest, Gas, Ice, Swamp
        public PlanetType Type { get; set; }

        public static int NumberOfPlanets { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Diameter}m, {Type}";
        }

    }
}
