using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    class Character :IAppearable, ILikeable
    {
        public Character(string FirstName="", string LastName="")
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SkinColor = "red";

            MovieAppearances = new List<Movie>();
        }

        protected string firstName = "Bob";
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value.Trim();
            }
        }

        public string LastName { get; set; }

        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }

        public string SkinColor { get;  set; }

        public Planet HomeWorld { get; set; }

        public List<Movie> MovieAppearances
        {
            get;
            set;
        }

        public int NumberOfLikes
        {
            get;

            set;
        }

        public override string ToString()
        {
            return $"{FullName} - Homeworld: {HomeWorld}";
        }

        public int NumberOfAppearances()
        {
            return MovieAppearances.Count;
        }

        public void Like()
        {
            NumberOfLikes++;
        }

        public void Unlike()
        {
            NumberOfLikes--;
        }
        
    }
}
