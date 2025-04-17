using System;

namespace VehicleProject
{

    public class Motorcycle : Vehicle
    {
        
        public Motorcycle(string model) : base(model)
        {
        }

    
        public override void Start()
        {
            Console.WriteLine($"Starting the motorcycle: {Model}");
        }

      
        public override void Stop()
        {
            Console.WriteLine($"Stopping the motorcycle: {Model}");
        }
    }
}