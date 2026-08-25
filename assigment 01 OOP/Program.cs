using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assigment_01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //DeliveryAddress is a struct (value type). When copied, a new independent copy is created.Modifying the copy does not affect the original variable.

            //b) What happens when a Customer variable is copied into another variable and one variable modifies the object
            //Customer is a class (reference type). When copied, both variables refer to the same object. Modifying the object through one variable affects the other variable.

            //a) Identify at least three problems with this design from an encapsulation perspective
            //The fields are public, so they can be modified directly from outside the struct.
            // There is no control or validation over the values.
            //The internal data is exposed, which breaks encapsulation.

            //b) How can private fields and public properties improve this design?
            //Use private fields with public properties.This hides the internal data and allows us to control access and add validation when needed.

            // part 2 partical 
            /*
            using System;

public struct DeliveryAddress
{
    public string City;
    public string Street;
    public int BuildingNumber;

    public DeliveryAddress(string city, string street, int buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }

    public string GetFullAddress()
    {
        return $"{BuildingNumber}, {Street}, {City}";
    }
}

public struct Shipment
{
    private string trackingCode;
    private string description;
    private double weight;
    private decimal deliveryFee;

    public string TrackingCode
    {
        get { return trackingCode; }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                description = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
                weight = value;
        }
    }

    public decimal DeliveryFee
    {
        get { return deliveryFee; }
        private set
        {
            if (value > 0)
                deliveryFee = value;
        }
    }

    public DeliveryAddress Destination { get; set; }

    public decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + ((decimal)Weight * 5);
        }
    }
}

class Program
{
    static void Main()
    {
        DeliveryAddress address1 =
            new DeliveryAddress("Cairo", "Main Street", 10);

        DeliveryAddress address2 = address1;

        address2.City = "Alexandria";

        Console.WriteLine(address1.GetFullAddress());
        Console.WriteLine(address2.GetFullAddress());
    }
}
            */


            // Q2 ,3 partical 
            /*
              public struct Shipment
{
    private string trackingCode;
    private string description;
    private double weight;
    private decimal deliveryFee;

    public string TrackingCode
    {
        get { return trackingCode; }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                description = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
                weight = value;
        }
    }

    public decimal DeliveryFee
    {
        get { return deliveryFee; }
        private set
        {
            if (value > 0)
                deliveryFee = value;
        }
    }

    public DeliveryAddress Destination { get; set; }

    public decimal EstimatedCost
    {
        get { return DeliveryFee + ((decimal)Weight * 5); }
    }

    public Shipment(string trackingCode)
    {
        this.trackingCode = trackingCode;
        this.description = "Unknown";
        this.weight = 1;
        this.deliveryFee = 50;
        this.Destination = new DeliveryAddress("Unknown", "Unknown", 0);
    }

    public Shipment(
        string trackingCode,
        string description,
        double weight,
        decimal deliveryFee,
        DeliveryAddress destination)
    {
        this.trackingCode = trackingCode;
        this.description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
        this.weight = weight > 0 ? weight : 1;
        this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
        this.Destination = destination;
    }

    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
        {
            deliveryFee = newFee;
        }
    }

    public void PrintShipment()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"Delivery Fee: {DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost}");
    }
}
            */
        }
    }
}
