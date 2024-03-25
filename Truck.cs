using System;

public class Truck : Vehicle
{
    // Additional properties specific to trucks
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Override DisplayDetails() method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity}, Truck Type: {TruckType}, Four-Wheel Drive: {FourWheelDrive}");
    }
}