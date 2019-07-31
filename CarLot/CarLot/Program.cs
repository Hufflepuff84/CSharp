using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program // this program class is the "driver" of the program. 
    {
        static void Main(string[] args)
        {  
            CarLot Person1 = new CarLot("All We Care About is Rims...That Part!");

            Person1.AddAutoMobile(new Truck("BIG PURP", "Dodge Ram", "1500", "19,999.99", "Big Bed"));

            Person1.AddAutoMobile(new Automobile("Low Ridr", "Honda Civic", "LX", "16,789.00", "White", "4"));

            Person1.PrintCarLot();

            
            CarLot Person2 = new CarLot("Hot Autos!");

            Person2.AddAutoMobile(new Truck("Mr French", "Chevrolet Tahoe", "2WDLS", "25,999.00", "4x4"));

            Person2.AddAutoMobile(new Automobile("MK5ZBG", "Lexus", "LX", "35,000", "Sedan", "0"));

            

            Person2.PrintCarLot();

            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class CarLot
    {
        public string Name { get; set; }  // this public string and public list exhibit the constructor method
        public List<Vehicle> Cars { get; set; }

        public CarLot(string name)
        {
            Name = name;
            Cars = new List<Vehicle>();
        }

        public void AddAutoMobile(Vehicle vehicle) // this adds automobiles to the carlot
        { 
            Cars.Add(vehicle);
        }

        public void PrintCarLot() // this prints the number of automobiles 
        { 
            Console.WriteLine(Name);
            Console.WriteLine((Cars.Count) + " automobiles are in the carlot");
            foreach (Vehicle auto in Cars)
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

        public abstract void PrintDetails(); // no initialization
    }

    class Truck : Vehicle
    {
        public string BedSize { get; set; }

        public Truck(string license, string make, string model, string price, string bedSize) :
            base(license, make, model, price)
        {
            BedSize = bedSize;
        }

        public override void PrintDetails() // this is the override code 
        { 
            Console.WriteLine();
            Console.WriteLine("Your make is:{0} Your model is: {1}, It's a truck with {2} bed(s); and the liscence plate number is: {3};" +
                " price: ${4}", Make, Model, BedSize, License, Price);
            Console.WriteLine();
        }
    }

    class Automobile : Vehicle
    {
        public string Type { get; set; }
        public string Doors { get; set; }

        public Automobile(string license, string make, string model, string price, string type, string doors) :
                base(license, make, model, price)
        {
            Type = type;
            Doors = doors;
        }

        public override void PrintDetails() // these are print statements for the overide
        { 
            Console.WriteLine();
            Console.WriteLine("{0} {1}, {2} with {3} doors; Plate #: {4};" +
                " this is the price: ${5}", Make, Model, Type, Doors, License, Price);
            Console.WriteLine();
        }
    }
}