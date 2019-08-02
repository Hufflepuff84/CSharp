using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IRentable> things = new List<IRentable>();

            things.Add(new Boat());
            things.Add(new House());
            things.Add(new Car());
            foreach(IRentable thing in things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
public interface IRentable
{
    
     int getDailyRate();
    
     string getDescription();
    
}
public class Boat: IRentable
{
    public int HourlyRate = 50;
    public string description = "Boat";
    public Boat()
    {

    }
    public string getDescription()
    {
        return description;
    }
    public int getDailyRate()
    {
        return HourlyRate * 24;
    }
    public override string ToString()
    {
        return getDescription() + ": " + getDailyRate();
    }
}
public class House: IRentable
{
    public string description = "House";
    public int WeeklyRate = 500;
    public House()
    {

    }
    public string getDescription()
    {
        return description;
    }
    public int getDailyRate()
    {
        return WeeklyRate / 7;
    }
    public override string ToString()
    {
        return getDescription() + ": " + getDailyRate();
    }
}
public class Car: IRentable
{
    public string description = "Car";
    public int DailyRate = 100;
    public Car()
    {

    }
    public string getDescription()
    {
        return description;
    }
    public int getDailyRate()
    {
        return DailyRate;
    }
    public override string ToString()
    {
        return getDescription() + ": " + getDailyRate();
    }
}