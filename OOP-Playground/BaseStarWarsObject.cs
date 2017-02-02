using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    abstract class BaseStarWarsObject
    {
        public BaseStarWarsObject()
        {
            MovieAppearances = new List<Movie>();
        }

        public List<Movie> MovieAppearances { get; set; }
    }
}
