using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfinityCodeTest.Domain.Entities;

namespace InfinityCodeTest.WebUI.Helper
{
    //Normally we would have the delivery and vheicle information stored in a databse and use something like Entity Framework to get the data being used 
    //in this project but since SQL is not available I will use this class to randomly generate the data for usage in this project
    public class CreateRandomData
    {
        public static Delivery[] GenerateDeliveryData()
        {
            //create a variable to hold the current Vehicle ID to be used
            int vehicleID = 1;
            //create the random variable for usage in the data creation(minimum of 5 to max of 10)
            Random random = new Random();
            int randomNumberOfDeliveries = random.Next(5, 10);

            var delivieries = new Delivery[randomNumberOfDeliveries];

            //now a for loop to begin creating random Delivery data
            for(int i = 0; i < randomNumberOfDeliveries; i++)
            {
                //randomize the number of vehicle types for this delivery (minimum of 2 to max of 5)
                int randomNumberOfVehicles = random.Next(2, 3);
                Vehicle[] vehicle = new Vehicle[randomNumberOfVehicles];

                //create at least 2 vehciles
                   
                //PickupTruck
                vehicle[0] = new PickupTruck
                {
                    ID = vehicleID++,
                    AverageMilesPerHour = random.Next(50, 80),
                    FuelGallonStorage = random.Next(1, 50),
                    LicensePlateNumber = random.Next(10000, 999999).ToString(), //For simplicity the license plat will be all numerical instead of alphnumerical
                    MilesPerGallon = random.Next(5, 30),
                    NumberOfAxels = random.Next(2, 4),
                    StorageCapacity = random.Next(100, 1000)
                };

                //Van
                vehicle[1] = new Van
                {
                    ID = vehicleID++,
                    AverageMilesPerHour = random.Next(50, 80),
                    FuelGallonStorage = random.Next(1, 50),
                    LicensePlateNumber = random.Next(10000, 999999).ToString(), //For simplicity the license plat will be all numerical instead of alphnumerical
                    MilesPerGallon = random.Next(5, 30),
                    NumberOfAxels = random.Next(2, 4),
                    StorageCapacity = random.Next(100, 1000)
                };

                //check to see if we need to create a 3rd
                if (randomNumberOfVehicles == 3)
                {
                    //BigRig
                    vehicle[2] = new BigRig
                    {
                        ID = vehicleID++,
                        AverageMilesPerHour = random.Next(50, 80),
                        FuelGallonStorage = random.Next(1, 50),
                        LicensePlateNumber = random.Next(10000, 999999).ToString(), //For simplicity the license plat will be all numerical instead of alphnumerical
                        MilesPerGallon = random.Next(5, 30),
                        NumberOfAxels = random.Next(2, 4),
                        StorageCapacity = random.Next(100, 1000)
                    };
                }

            

                //Now that we have the vehicles generate the delivery using random values for properties
                delivieries[i] = new Delivery(i + 1, random.Next(0, 24), random.Next(10, 1000), vehicle); ;
            }

            return delivieries;
        }
    }
}