using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    public enum PlanetType {Desert, Forest, Gas, Ice, Swamp }
    
    class Planet : IAppearable
    {
        public Planet()
        {
            NumberOfPlanets++;
            MovieAppearances = new List<Movie>();
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

        public List<Movie> MovieAppearances
        {
            get;

            set;
        }

        public override string ToString()
        {
            return $"{Name}, {Diameter}m, {Type}";
        }

        public int NumberOfAppearances()
        {
            return MovieAppearances.Count;
        }

    }
}
