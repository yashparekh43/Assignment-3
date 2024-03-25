using System;

public class RentalAgency
{
    // Fields
    private Vehicle[] Fleet;
    private decimal TotalRevenue;

    // Constructor
    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
        TotalRevenue = 825;
    }

    // Methods
    public void AddVehicle(Vehicle vehicle, int index)
    {
        Fleet[index] = vehicle;
    }

    public void RemoveVehicle(int index)
    {
        Fleet[index] = null;
    }

    public void RentVehicle(int index, int days)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice * days;
            RemoveVehicle(index);
        }
    }

    public decimal GetTotalRevenue()
    {
        return TotalRevenue;
    }
}