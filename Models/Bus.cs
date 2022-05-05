using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Task.Models
{
    class Bus : Vehicle
    {
        public byte PassengerCount;

        public Bus()
        {
        }

        public Bus(string brand, string model, string colour, byte maxSpeed, byte passengerCount) : base(brand, model, colour, maxSpeed)       
        {
            PassengerCount = passengerCount;
        }

        public override string Info()
        {
            return $"Brand: {Brand}, Model: {Model}, Colour {Colour}, Max speed {MaxSpeed}, Passenger count: {PassengerCount}";
        }
    }
}
