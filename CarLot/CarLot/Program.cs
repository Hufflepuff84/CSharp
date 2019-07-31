using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLots
{
    class Program // "engine of the program"
    {
        static void Main(string[] args)
        {
        }
}

    }
public class Lot
{
    string name;
    static List<OfVehicles> Vehicles = new List<OfVehicles>();
    
}

public abstract class OfVehicles
{
    int liscenceno;
    string make;
    string model;
    int price;
}

public class Truck : OfVehicles
{

}

public class Car: OfVehicles
{

}


namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {   //                                      First Car lot with 3 cars
            CarLot Troys = new CarLot("TMoney's Slammin' Rides");

            Troys.AddCar(new Truck("IMNO UG", "Chervoling", "C550", "999.99", "Scary Long"));

            Troys.AddCar(new Car("UR P00R", "Cadolact", "La Desparado", "55k", "Sedan", "4"));

            Troys.AddCar(new Car("FSTR BSTR", "Evade", "Attacker", "43945.27", "Sportscar", "2"));

            Troys.PrintLot();

            //                                      Second Car lot with 4 cars
            CarLot Mama = new CarLot("Mrs. Friskey's Shagin' Wagons");

            Mama.AddCar(new Truck("LVR TRKR", "Frog", "River Raider", "1999.99", "Double"));

            Mama.AddCar(new Car("BIG FMLY", "VMB", "2210", "15k", "Station Wagon", "4"));

            Mama.AddCar(new Car("N0 1 RKN", "Yuido", "Sleeper 8", "28951.27", "Van", "5"));

            Mama.AddCar(new Car("1 NITE 4U", "Ocelot", "Party Hauler", "534.28/Month", "Limo", "8"));

            Mama.PrintLot();

            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class CarLot
    {
        public string Name { get; set; }
        public List<Vehicle> Autos { get; set; }

        public CarLot(string name)
        {
            Name = name;
            Autos = new List<Vehicle>();
        }

        public void AddCar(Vehicle vehicle)
        { // adds car to carlot list
            Autos.Add(vehicle);
        }

        public void PrintLot()
        { // prints the lot name number of cars and details from truck or car class
            Console.WriteLine(Name);
            Console.WriteLine(Autos.Count + " Vehicles on the Lot!");
            foreach (Vehicle auto in Autos)
            {
                auto.PrintDetails();
            }
        }
    }

    public abstract class Vehicle
    {
        public string License { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }

        public Vehicle(string license, string make, string model, string price)
        {
            License = license;
            Make = make;
            Model = model;
            Price = price;
        }

        public abstract void PrintDetails(); // method with no body, because it can't be instantiated
    }

    class Truck : Vehicle
    {
        public string BedSize { get; set; }

        public Truck(string license, string make, string model, string price, string bedSize) :
            base(license, make, model, price)
        {
            BedSize = bedSize;
        }

        public override void PrintDetails()
        { // overide abtract method specific to truck, prints relevant fields
            Console.WriteLine();
            Console.WriteLine("{0} {1}, Truck with {2} bed; Plate #: {3};" +
                " ${4}", Make, Model, BedSize, License, Price);
            Console.WriteLine();
        }
    }

    class Car : Vehicle
    {
        public string Type { get; set; }
        public string Doors { get; set; }

        public Car(string license, string make, string model, string price, string type, string doors) :
                base(license, make, model, price)
        {
            Type = type;
            Doors = doors;
        }

        public override void PrintDetails()
        { // overide abtract method specific to car, prints relevant fields
            Console.WriteLine();
            Console.WriteLine("{0} {1}, {2} with {3} doors; Plate #: {4};" +
                " ${5}", Make, Model, Type, Doors, License, Price);
            Console.WriteLine();
        }
    }
}