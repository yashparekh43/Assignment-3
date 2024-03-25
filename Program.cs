using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;


class Program
{
    static void Main(string[] args)
    {
        // Create instances of vehicles
        Car car = new Car
        {
            Model = "Grand Cherokee",
            Manufacturer = "Jeep",
            Year = 2019,
            RentalPrice = 90,
            Seats = 4,
            EngineType = "J8",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "New Actros",
            Manufacturer = "Chevrolet",
            Year = 2021,
            RentalPrice = 165,
            Capacity = 3,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "BMW",
            Manufacturer = "M 1000R",
            Year = 2020,
            RentalPrice = 40,
            EngineCapacity = 999,
            FuelType = "Gasoline",
            HasFairing = true
        };

        // Display vehicle details
        car.DisplayDetails();
        Console.WriteLine();

        truck.DisplayDetails();
        Console.WriteLine();

        motorcycle.DisplayDetails();
        Console.WriteLine();

        // Rental agency
        RentalAgency rentalAgency = new RentalAgency(14);
        rentalAgency.AddVehicle(car, 3);
        rentalAgency.AddVehicle(truck, 2);
        rentalAgency.AddVehicle(motorcycle, 4);

        // Rent a vehicle
        Console.WriteLine("Renting the truck for 5 days...");
        rentalAgency.RentVehicle(1, 5);
        Console.WriteLine($"Total revenue: {rentalAgency.GetTotalRevenue():C}");
    }
}