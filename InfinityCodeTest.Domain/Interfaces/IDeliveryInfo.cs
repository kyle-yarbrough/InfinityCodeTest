using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityCodeTest.Domain.Entities;

namespace InfinityCodeTest.Domain.Interfaces
{
    //Design parameters require at least 1 interface so we will create a Delivery Interface
    public interface IDeliveryInfo
    {
        #region Properties
        int ID { get; }
        decimal DepartureTime { get;  }
        decimal DestinationMileage { get; }
        decimal DevileryTime { get; }
        string TrackingNumber { get; }
        Vehicle[] Vehicles { get; }
        #endregion

        #region Method Signatures

        #endregion
    }
}
