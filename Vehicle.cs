using System;
public class Vehicle
{
    // Properties
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public decimal RentalPrice { get; set; }

    // Methods
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice:C}");
    }
}