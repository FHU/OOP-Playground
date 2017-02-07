using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    interface IAppearable
    {
        List<Movie> MovieAppearances { get; set; }

        int NumberOfAppearances();

    }
}
