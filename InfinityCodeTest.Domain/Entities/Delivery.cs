using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityCodeTest.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace InfinityCodeTest.Domain.Entities
{
    public class Delivery : IDeliveryInfo
    {
        #region Private Properties
        private int deliveryID;
        private string trackingNumber;
        private decimal depatureTime;
        private decimal destinationMileage;
        private decimal deliveryTime;
        private Vehicle[] vehicles;
        #endregion

        #region Public Properties
        public int ID { get { return deliveryID; } }
        [Display(Name = "Departure Time")]
        public decimal DepartureTime { get { return depatureTime; }}
        [Display(Name = "Destination Mileage")]
        public decimal DestinationMileage { get { return destinationMileage; } }
        [Display(Name = "Devilery Time (in hours)")]
        public decimal DevileryTime { get{ return deliveryTime; } }
        [Display(Name = "Tracking Number")]
        public string TrackingNumber { get { return trackingNumber; } }
        public Vehicle[] Vehicles { get { return vehicles; } }
        #endregion 

        #region Public Methods
        //Constructor to force required fields to be populated for other calculations.
        public Delivery(int DeliveryID,decimal DepartureTime, decimal DestinationMileage, Vehicle[] Vehicles)
        {
            //Set the private propertie values based on parameters sent into the Constructor
            deliveryID = DeliveryID;
            depatureTime = DepartureTime;
            destinationMileage = DestinationMileage;
            vehicles = Vehicles;

            //Generate a tracking number for this delivery
            GenerateTrackingNumber();

            //Call to Calcualate Delivery Time
            CalculateDeliveryTime();

        }
        #endregion

        #region Private Methods
        //Method that will calculate the Deilivery Time using the information sent into the Constructor
        private void CalculateDeliveryTime()
        {
            //Since there can be multiple Trucks on the delivery the final delivery time is calculated as the final truck to reach the destination. Assuming all vehicles leave at the same time from the same location.

            //declare variable to hold the slowest truck MilesPerHour
            decimal slowestTruckMileage = vehicles.Min(s => s.AverageMilesPerHour);

            //calculate the total delivery time of the slowest truck
            deliveryTime = Math.Round(destinationMileage / slowestTruckMileage,2);

        }

        //Method will generate a Guid as the unique Tracking Number for this delivery. If the logic of the tracking numbergeneration changes then it can be adjusted in this method.
        private void GenerateTrackingNumber()
        {
            trackingNumber = Guid.NewGuid().ToString();
        }
        #endregion
    }
}
