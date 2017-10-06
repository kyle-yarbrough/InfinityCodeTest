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
        #region Private Properties
        #endregion

        #region Public Methods
        public PickupTruck()
        {
            VehicleType = "Pickup Truck";
        }
        #endregion
    }
}
