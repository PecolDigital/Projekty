namespace VehicleProject
{
    public abstract class Vehicle
    {
        public string Model { get; set; }

        // To będzie model pojazdu 
        public Vehicle(string model)
        {
            Model = model;   // Konstruktor – odpala się przy tworzeniu pojazdu, wrzucasz mu model i gotowe
        }
        
        public abstract void Start();// Abstrakcyjna metoda Start, czyli każdy pojazd musi powiedzieć jak się uruchamia
        public abstract void Stop(); // Abstrakcyjna metoda Stop, no i każdy musi umieć się zatrzymać, wiadomo
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Uruchamiamy  auto i motor 
            Vehicle car = new Car("BMW");
            car.Start();  
            car.Stop();   

            Vehicle motorcycle = new Motorcycle("Harley");
            motorcycle.Start();  
            motorcycle.Stop();   
        }
    }
}

