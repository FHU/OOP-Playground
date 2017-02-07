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

    abstract class  Vehicle: IAppearable
    {

        protected int FuelStores;

        public Vehicle()
        {
            MovieAppearances = new List<Movie>();
        }

        public Affiliation Affiliation { get; set; }

        public string Model { get; set; }

        public double Height { get; set; }

        public int CrewSize { get; set; }

        public List<Movie> MovieAppearances
        {
            get;

            set;
        }

        public virtual void Refuel()
        {
            FuelStores += 1000;
        }

        public abstract void Move();


        public override string ToString()
        {
            return $"{Model}: {Affiliation}, Crew Size: {CrewSize}, Height: {Height}";
        }

        public int NumberOfAppearances()
        {
            return MovieAppearances.Count +2 ;
        }
    }
}
