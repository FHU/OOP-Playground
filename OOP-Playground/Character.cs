using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    class Character: BaseStarWarsObject
    {
        public Character(string FirstName="", string LastName="")
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SkinColor = "red";
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

        public string SkinColor { get;  set; }

        public Planet HomeWorld { get; set; }

    }
}
