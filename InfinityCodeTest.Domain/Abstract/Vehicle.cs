using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InfinityCodeTest.Domain.Entities
{
    //Design parameters require at least 1 abstract class so we will create a Vehicle class that is abstract
    public abstract class Vehicle
    {
        //Begin Public Properties
        public int ID { get; set; }
        [Display(Name = "Average Miles Per Hour")]
        public decimal AverageMilesPerHour { get; set; }
        [Display(Name = "Miles Per Gallon")]
        public decimal MilesPerGallon {get; set; }
        [Display(Name = "Fuel Gallon Storage")]
        public decimal FuelGallonStorage { get; set; }
        [Display(Name = "License Plate Number")]
        public string LicensePlateNumber { get; set; }
        [Display(Name = "Number Of Axels")]
        public int NumberOfAxels { get; set; }
        [Display(Name = "Storage Capacity")]
        public decimal StorageCapacity { get; set; }
        [Display(Name = "Vehicle Type")]
        public string VehicleType { get; set; }
        //End Public Properties

        //Begin Public Methods
        public decimal CalculateDeliveryTime(decimal MileageToDestination)
        {
            return MileageToDestination / AverageMilesPerHour;
        }

        public decimal CalculateMilesPerTank()
        {
            return FuelGallonStorage * MilesPerGallon;
        }

        public decimal GetTravelTimeByMileage(decimal Mileage)
        {
            return Math.Round(Mileage / this.AverageMilesPerHour, 2);
        }
        //End Public Methods
    }
}
