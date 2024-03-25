using System;

public class Car : Vehicle
{
    // Additional properties specific to cars
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    // Override DisplayDetails() method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");
    }
}
