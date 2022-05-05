using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Task.Models
{
    abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public string Colour;
        public byte MaxSpeed;

        public Vehicle() 
        
        {
            Console.WriteLine("Car Created");
        }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Vehicle(string brand, string model, string colour, byte maxSpeed): this(brand,model)
        {
            Colour = colour;
            MaxSpeed = maxSpeed;
        }



        public abstract string Info();
    }
}
