using System;
using Calculators;
using CommercialRegistration;
using ConsumerVehicleRegistration;
using LiveryRegistration;

namespace ConsumerVehicleRegistration
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var tollCalc = new TollCalculator();
            Car car = new();
            Console.WriteLine(tollCalc.CalculateToll(car));
            Console.ReadLine();
        }
    }
}

namespace Calculators
{
    public class TollCalculator
    {
        public decimal CalculateToll(object vehicle)
        {
            return vehicle switch
            {
                Car => 2.00m,
                Taxi => 3.50m,
                Bus => 5.00m,
                DeliveryTruck => 10.00m,
                { } => throw new ArgumentException(message: "Not a known vehicle type", paramName: nameof(vehicle)),
                _ => throw new ArgumentNullException(nameof(vehicle))
            };
        }
    }
}
namespace ConsumerVehicleRegistration
{
    public class Car
    {
        public int Passengers { get; set; }
    }
}

namespace CommercialRegistration
{
    public class DeliveryTruck
    {
        public int GrossWeightClass { get; set; }
    }
}

namespace LiveryRegistration
{
    public class Taxi
    {
        public int Fares { get; set; }
    }

    public class Bus
    {
        public int Capacity { get; set; }
        public int Riders { get; set; }
    }
}