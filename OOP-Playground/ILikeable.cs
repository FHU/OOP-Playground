using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    interface ILikeable
    {

        void Like();
        void Unlike();

        int NumberOfLikes { get; set; }


    }
}
