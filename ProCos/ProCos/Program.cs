using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver bob = new Driver();
            bob.FirstName = "Bob";
            bob.LastName = "Blart";
            bob.LicenseNumber = 88888888;
            bob.Gender = "Male";

            Driver sally = new Driver();
            sally.FirstName = "Sally";
            sally.LastName = "Fields";
            sally.LicenseNumber = 77777777;
            sally.Gender = "Female";

            Console.WriteLine("{0} license number {1}, {2}.",
                bob.Gender, bob.LicenseNumber, bob.FullName()
                );
            Console.WriteLine();

            Console.WriteLine("{0} license number {1}, {2}.",
                sally.Gender, sally.LicenseNumber, sally.FullName()
                );
            Console.WriteLine();

            Book epic = new Book();
            epic.Title = " 'The Bears' ";
            epic.Authors = new string[] { "Mike", "Ditka" };
            epic.Pages = 999;
            epic.SKU = "CH3123B1";
            epic.Publisher = "Bumblebee";
            epic.Price = 54.99M;

            Console.WriteLine("From {0}: {1} by {2}: {3} Pages: " +
                "Price ${4}: SKU {5}", epic.Publisher, epic.Title,
                epic.Authors[1], epic.Pages, epic.Price, epic.SKU
                );
            Console.WriteLine();


            Plane southwestPlane = new Plane("");
            southwestPlane.Manufacturer = "Boeing";
            southwestPlane.Model = "747";
            southwestPlane.Variant = "Shamoo";
            southwestPlane.Capacity = 90;
            southwestPlane.Engines = "Triple";


            Console.WriteLine(" A {0}, {1} engine powered, {2} {3} {4} " +
                "with room for {5}", southwestPlane.Color, southwestPlane.Engines,
                southwestPlane.Manufacturer, southwestPlane.Model, southwestPlane.Variant,
                southwestPlane.Capacity);
            Console.WriteLine();

            Console.ReadKey();
        }

    }

    public class Driver
    {
        public String FirstName;
        public String LastName;
        public int LicenseNumber;
        public String Gender;


        public string FullName()
        {
            string space = " ";
            string FullName = String.Concat(FirstName, space, LastName);
            return FullName;

        }

    }

    public class Book
    {
        public String Title;
        public String[] Authors;
        public int Pages;
        public String SKU;
        public String Publisher;
        public Decimal Price;

    }

    public class Plane
    {
        public String Manufacturer;
        public String Model;
        public String Variant;
        public int Capacity;
        public String Engines;

        public string Color { get; set; }

        public Plane(string initialColor)
        {
            Color = initialColor;
        }

    }



}