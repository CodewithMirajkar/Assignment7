//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
    

//    abstract class Vehicle
//    {
//        public string Make { get; }
//        public string Model { get; }
//        public int Year { get; }

//        protected Vehicle(string make, string model, int year)
//        {
//            Make = make;
//            Model = model;
//            Year = year;
//        }

//        // Abstract method to get vehicle details
//        public abstract string GetDetails();
//    }

//    interface IDriveable
//    {
//        // Method to drive the vehicle
//        void Drive();
//    }

//    class Car : Vehicle, IDriveable
//    {
//        public int NumberOfDoors { get; }

//        public Car(string make, string model, int year, int numberOfDoors)
//            : base(make, model, year)
//        {
//            NumberOfDoors = numberOfDoors;
//        }

//        // Implement GetDetails
//        public override string GetDetails()
//        {
//            return $"{Year} {Make} {Model}, Doors: {NumberOfDoors}";
//        }

//        // Implement Drive
//        public void Drive()
//        {
//            Console.WriteLine($"Driving a car: {GetDetails()}");
//        }
//    }

//    class Bike : Vehicle, IDriveable
//    {
//        public bool HasCarrier { get; }

//        public Bike(string make, string model, int year, bool hasCarrier)
//            : base(make, model, year)
//        {
//            HasCarrier = hasCarrier;
//        }

//        // Implement GetDetails
//        public override string GetDetails()
//        {
//            return $"{Year} {Make} {Model}, Carrier: {(HasCarrier ? "Yes" : "No")}";
//        }

//        // Implement Drive
//        public void Drive()
//        {
//            Console.WriteLine($"Riding a bike: {GetDetails()}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IDriveable myCar = new Car("Toyota", "Camry", 2021, 4);
//            IDriveable myBike = new Bike("Yamaha", "MT-07", 2022, false);

//            myCar.Drive();
//            myBike.Drive();
//            Console.ReadLine();
//        }
//    }

//}
