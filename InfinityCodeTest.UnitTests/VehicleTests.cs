using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InfinityCodeTest.Domain.Entities;

namespace InfinityCodeTest.UnitTests
{
    [TestClass]
    //A Vehicle can be tested to accurately calculate and return travel time.
    public class VehicleTests
    {
        [TestMethod]
        public void Can_Calculate_Travel_Time()
        {
            //arrange
            Vehicle truck = new PickupTruck {
                ID = 1,
                AverageMilesPerHour = 60,
                FuelGallonStorage = 36,
                LicensePlateNumber = "ASD564",
                MilesPerGallon = 12.4M,
                NumberOfAxels = 2,
                StorageCapacity = 4500 };

            decimal expectedValueToTest = 2;

            //act
            decimal travelTime = truck.GetTravelTimeByMileage(120);

            //assert
            Assert.AreEqual(expectedValueToTest, travelTime, "Travel Time is worng");
        }
    }
}
