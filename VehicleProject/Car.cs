using System;
using System.Reflection;

namespace VehicleProject
{
    
    public class Car : Vehicle   // Mówimy: Car to Vehicle. Dziedziczymy jak syn po ojcu.
    { 
        public Car(string model) : base(model)// Konstruktor – przekazujemy model do klasy bazowej
    {
        }


        public override void Start()
        {
            Console.WriteLine($"Starting the car: {Model}");
        }

  
        public override void Stop()
    {
            Console.WriteLine($"Stopping the car: {Model}");
        }
    }
}