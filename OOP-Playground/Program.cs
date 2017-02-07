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
            Character c = new Character()
            {
                FirstName ="Kylo",
                LastName ="Ren",
                HomeWorld = new Planet() { Name="Jakku", Diameter=65, Type=PlanetType.Desert}
            };

            Planet t = Planet.CreateTatooine();

            Vehicle v = new SpaceVehicle() { Affiliation = Affiliation.Rebellion, Height=35.2, Model="X-Wing"};

            Console.WriteLine(c);
            Console.WriteLine(v);
            Console.WriteLine(t);

            IAppearable ia = new GroundVehicle();

            var listofiappearables = new List<IAppearable>();
            listofiappearables.Add(c);
            listofiappearables.Add(v);
            listofiappearables.Add(t);

            foreach(var item in listofiappearables)
            {
                Console.WriteLine( item.NumberOfAppearances() );
            }

            /*var listOfStarWarsThings = new List<BaseStarWarsObject>();
            listOfStarWarsThings.Add(c);
            listOfStarWarsThings.Add(v);
            listOfStarWarsThings.Add(t);

            foreach( var item in listOfStarWarsThings)
            {
                Console.WriteLine(item.ToString() );
            }*/

            /*BaseStarWarsObject b;
            b = c;
            Console.WriteLine( b.ToString());

            b = v;
            Console.WriteLine(b.ToString());*/


            //SpaceVehicle cruiser = new SpaceVehicle();
            //cruiser.MovieAppearances.Add(new Movie() { Title = "A New Hope" });

            //Console.WriteLine(Planet.NumberOfPlanets);

            Console.ReadKey();
        }
    }
}
