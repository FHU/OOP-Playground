using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    class GroundVehicle: Vehicle
    {
        public int MaxSpeed { get; set; }

        public override void Refuel()
        {
            FuelStores += 200;
        }

        public override void Move()
        {
            //Do something...
        }

    }
}
