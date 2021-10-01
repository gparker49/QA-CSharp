using System;
using System.Collections.Generic;

namespace VehicleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();
            Motorbike harley = new Motorbike();
            Truck nissan = new Truck();

            ford.Wheels = 4;
            ford.Colour = "blue";
            ford.Fuel = "electric";

            harley.Wheels = 2;
            harley.Colour = "black";
            harley.Fuel = "disel";

            nissan.Wheels = 8;
            nissan.Colour = "white";
            nissan.Fuel = "petrol";


            Console.WriteLine(ford.ToString());
            Console.WriteLine(harley.ToString());
            Console.WriteLine(nissan.ToString());

        }
    }

    
    class Vehicle
    {
        private int wheels;
        private string colour;
        private string fuel;

        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
    }

    class Car : Vehicle
    {
        public override string ToString()
        {
            return $"The car has {Wheels} wheels, is {Colour} in colour and uses the fueltype {Fuel}.";
        }
    }

    class Motorbike : Vehicle
    {
        public override string ToString()
        {
            return $"The motorbike has {Wheels} wheels, is {Colour} in colour and uses the fueltype {Fuel}.";
        }
    }

    class Truck : Vehicle
    {
        public override string ToString()
        {
            return $"The truck has {Wheels} wheels, is {Colour} in colour and uses the fueltype {Fuel}.";
        }
    }

    class Garage
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        
        
        
        
        
       
            

        
        
    }
}