using System;

public class Motorcycle : Vehicle
{
    // Additional properties specific to motorcycles
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    // Override DisplayDetails() method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
    }
}
