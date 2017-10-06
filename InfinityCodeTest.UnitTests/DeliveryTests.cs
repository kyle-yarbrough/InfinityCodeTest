using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InfinityCodeTest.Domain.Entities;
using InfinityCodeTest.Domain.Interfaces;

namespace InfinityCodeTest.UnitTests
{
    [TestClass]
    public class DeliveryTests
    {
        /*
         * 
          A Delivery can be tested to:
            2.1) Create a departure time ( See **TIME).
            2.2) Calculate and return the delivery time ( See **TIME).
            2.3) Return a unique delivery tracking number ( See **TRACKING).
 

            **TIME: For the purpose of this exercise Time will be Hours. Hundreths of hours
            **TRACKING: Persistence is NOT part of this exercise so the uniqueness is Per-Process.
 
         * 
         * 
         */
        [TestMethod]
        public void Can_Create_Departure_Time()
        {
            //arrange
            decimal expectedValue = 2;

            Vehicle[] vehicle =
                {
                    new PickupTruck {
                        ID = 1,
                        AverageMilesPerHour = 60,
                        FuelGallonStorage = 36,
                        LicensePlateNumber = "ASD564",
                        MilesPerGallon = 12.4M,
                        NumberOfAxels = 2,
                        StorageCapacity = 4500
                    }
                };

            Delivery delivery = new Delivery(1, 2, 34, vehicle);

            //act
            //No action here as Delivery constructor takes care of the action

            //assert
            Assert.AreEqual(expectedValue, delivery.DepartureTime, "Departure Time is not equal");
        }

        [TestMethod]
        public void Can_Calculate_Delivery_Time()
        {
            //arrange
            decimal expectedValue = 4;

            Vehicle[] vehicle =
                {
                    new PickupTruck {
                        ID = 1,
                        AverageMilesPerHour = 60,
                        FuelGallonStorage = 36,
                        LicensePlateNumber = "ASD564",
                        MilesPerGallon = 12.4M,
                        NumberOfAxels = 2,
                        StorageCapacity = 4500
                    },
                    new Van {
                        ID = 2,
                        AverageMilesPerHour = 30,
                        FuelGallonStorage = 24,
                        LicensePlateNumber = "AH3564",
                        MilesPerGallon = 10.1M,
                        NumberOfAxels = 4,
                        StorageCapacity = 5000
                    }
                };

            Delivery delivery = new Delivery(1, 2, 120, vehicle);

            //act
            //No action here as Delivery constructor takes care of the action

            //assert
            Assert.AreEqual(expectedValue, delivery.DevileryTime, "Delivery Time is not equal");
        }

        [TestMethod]
        public void Can_Generate_Tracking_Number()
        {
            //arrange

            Vehicle[] vehicle1 =
                {
                    new PickupTruck {
                        ID = 1,
                        AverageMilesPerHour = 60,
                        FuelGallonStorage = 36,
                        LicensePlateNumber = "ASD564",
                        MilesPerGallon = 12.4M,
                        NumberOfAxels = 2,
                        StorageCapacity = 4500
                    }
                };

            //Setup to identical Deliveries
            Delivery delivery1 = new Delivery(1, 2, 34, vehicle1);
            Delivery delivery2 = new Delivery(1, 2, 34, vehicle1);

            //act
            //No action here as Delivery constructor takes care of the action

            //assert
            Assert.AreNotEqual(delivery1.TrackingNumber, delivery2.TrackingNumber, "Tracking Numbers is not equal");
        }
    }
}
