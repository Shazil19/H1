using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne_kommer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Robots cleaningRobot = new Robots("RX54667", false, "white", 0, 2.3);
            Robots tireChangingRobot = new Robots("QT8339", false, "white", 4);
            Robots windowCleaningRobot = new Robots("RX54667", true, "red", 2, 2.3);

            Console.WriteLine("Cleaning Robot:");
            Console.WriteLine("Microchip: " + cleaningRobot.Microchip);
            Console.WriteLine("Has WiFi: " + cleaningRobot.HasWifi);
            Console.WriteLine("Color: " + cleaningRobot.Color);
            Console.WriteLine("Wheels: " + cleaningRobot.Wheels);
            Console.WriteLine("Soap Container: " + cleaningRobot.CleaningRobots + " liters");
            Console.WriteLine("Capacity: " + cleaningRobot.Battery + "\n");

            Console.WriteLine("Tire Changing Robot:");
            Console.WriteLine("Microchip: " + tireChangingRobot.Microchip);
            Console.WriteLine("Has WiFi: " + tireChangingRobot.HasWifi);
            Console.WriteLine("Color: " + tireChangingRobot.Color);
            Console.WriteLine("Wheels: " + tireChangingRobot.Wheels);
            Console.WriteLine("Soap Container: " + tireChangingRobot.CleaningRobots + " liters");
            Console.WriteLine("Capacity: " + tireChangingRobot.Battery + "\n");

            Console.WriteLine("Window Cleaning Robot:");
            Console.WriteLine("Microchip: " + windowCleaningRobot.Microchip);
            Console.WriteLine("Has WiFi: " + windowCleaningRobot.HasWifi);
            Console.WriteLine("Color: " + windowCleaningRobot.Color);
            Console.WriteLine("Wheels: " + windowCleaningRobot.Wheels);
            Console.WriteLine("Soap Container: " + windowCleaningRobot.CleaningRobots + " liters");
            Console.WriteLine("Capacity: " + windowCleaningRobot.Battery + "\n");

            Console.ReadLine();

            Console.WriteLine("Change the amount of liter in the window cleaning robot");

            double change = double.Parse(Console.ReadLine());

            change = windowCleaningRobot.CleaningRobots;
            Console.WriteLine("Soap Container: " + windowCleaningRobot.CleaningRobots + " liters");

        }
    }
    public class Robots
    {

        private int _battery;
 
        public int Battery
        {
            get { return _battery; }
            private set { _battery = value; }
        }

        private double _cleaning_robots;

        public double CleaningRobots
        {
            get { return _cleaning_robots; }
            private set { _cleaning_robots = value; }
        }

        private bool _haswifi;

        public bool HasWifi
        {
            get { return _haswifi; }
            private set { _haswifi = value; }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            private set { _color = value; }
        }

        private int _wheels;

        public int Wheels
        {
            get { return _wheels; }
            private set { _wheels = value; }
        }

        private string _microchip;

        public string Microchip
        {
            get { return _microchip; }
            private set { _microchip = value; }
        }
            
        public Robots(string microchip, bool hasWifi, string color, int wheels, double cleaningrobot = 0, int battery = 0)
        {
            Microchip = microchip;
            HasWifi = hasWifi;
            Color = color;
            Wheels = wheels;
            CleaningRobots = cleaningrobot;
            Battery = battery;
        }

        
    }
}