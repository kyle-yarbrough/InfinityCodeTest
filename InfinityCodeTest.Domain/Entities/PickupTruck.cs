using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InfinityCodeTest.Domain.Entities
{
    public class PickupTruck : Vehicle
    {
        //Begin Public Properties
        //End Public Properties

        //Begin Public Methods
       public PickupTruck()
        {
            VehicleType = "Pickup Truck";
        }
        //End PublicMethods
    }
}
