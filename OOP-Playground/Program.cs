using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            Planet p = new Planet();
            p.Type = PlanetType.Desert;

            Planet h = new Planet();
            Planet t = Planet.CreateTatooine();

            Vehicle v = new Vehicle() { Affiliation = Affiliation.Rebellion, Height=35.2, Model="X-Wing"};

            BaseStarWarsObject b = new Planet();

            SpaceVehicle cruiser = new SpaceVehicle();
            cruiser.MovieAppearances.Add(new Movie() { Title = "A New Hope" });

            Console.WriteLine(p);

            Console.WriteLine(Planet.NumberOfPlanets);

            Console.ReadKey();
        }
    }
}
