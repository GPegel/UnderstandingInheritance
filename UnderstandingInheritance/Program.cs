using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 1998;
            myCar.Color = "Red";

            printVehicleDetail(myCar);
            

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Purple";
            myTruck.TowingCapacity = 1500;

            printVehicleDetail(myTruck);

            Console.ReadLine();


        }
        private static void printVehicleDetail(Vehicle vehicle)
        {
            Console.WriteLine("Here are the vehicle's details: {0}",
                vehicle.FormatMe());
        }
    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();

    }

    class Car : Vehicle
    {
        

        public override string FormatMe()
        {
            return string.Format("{0}, {1}, {2}, {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }

    sealed class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }
        public override string FormatMe()
        {
            return string.Format("{0}, {1}, {2} towing units.",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }

    }

    class Semi
    {
        
    }
}
