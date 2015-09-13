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

            printCarDetail(myCar);
            

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Purple";
            myTruck.TowingCapacity = 1500;

            printCarDetail(myTruck);

            Console.ReadLine();


        }
        private static void printCarDetail(Car car)
        {
            Console.WriteLine("Here are the car details: {0}",
                car.FormatMe());
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public string FormatMe()
        {
            return string.Format("{0}, {1}, {2}, {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }

    class Truck : Car
    {
        public int TowingCapacity { get; set; }

    }
}
