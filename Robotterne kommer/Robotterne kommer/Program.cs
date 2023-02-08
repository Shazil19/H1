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

            Robot cleaningRobot = new Robot("RX54667", false, "white", 0, 2.3);
            Robot tireChangingRobot = new Robot("QT8339", false, "white", 4);
            Robot windowCleaningRobot = new Robot("RX54667", true, "red", 2, 2.3);

            Console.WriteLine("Cleaning Robot:");
            Console.WriteLine("Microchip: " + cleaningRobot.Microchip);
            Console.WriteLine("Has WiFi: " + cleaningRobot.HasWifi);
            Console.WriteLine("Color: " + cleaningRobot.Color);
            Console.WriteLine("Wheels: " + cleaningRobot.Wheels);
            Console.WriteLine("Soap Container: " + cleaningRobot.CleaningRobot + " liters");
            Console.WriteLine("Capacity: " + cleaningRobot.Battery + "\n");

            Console.WriteLine("Tire Changing Robot:");
            Console.WriteLine("Microchip: " + tireChangingRobot.Microchip);
            Console.WriteLine("Has WiFi: " + tireChangingRobot.HasWifi);
            Console.WriteLine("Color: " + tireChangingRobot.Color);
            Console.WriteLine("Wheels: " + tireChangingRobot.Wheels);
            Console.WriteLine("Soap Container: " + tireChangingRobot.CleaningRobot + " liters");
            Console.WriteLine("Capacity: " + tireChangingRobot.Battery + "\n");

            Console.WriteLine("Window Cleaning Robot:");
            Console.WriteLine("Microchip: " + windowCleaningRobot.Microchip);
            Console.WriteLine("Has WiFi: " + windowCleaningRobot.HasWifi);
            Console.WriteLine("Color: " + windowCleaningRobot.Color);
            Console.WriteLine("Wheels: " + windowCleaningRobot.Wheels);
            Console.WriteLine("Soap Container: " + windowCleaningRobot.CleaningRobot + " liters");
            Console.WriteLine("Capacity: " + windowCleaningRobot.Battery + "\n");

            Console.ReadLine();

            Console.WriteLine("Change the amount of liter in the window cleaning robot");

            double change = double.Parse(Console.ReadLine());

            change = windowCleaningRobot.CleaningRobot;
            Console.WriteLine("Soap Container: " + windowCleaningRobot.CleaningRobot + " liters");

        }
    }
    public class Robot
    {

        private int _battery;
 
        public int Battery
        {
            get { return _battery; }
            private set { _battery = value; }
        }

        private double _cleaning_Robot;

        public double CleaningRobot
        {
            get { return _cleaning_Robot; }
            private set { _cleaning_Robot = value; }
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

        public Robot(string microchip)
        {
            Microchip = microchip;
        }

        public Robot(string microchip, bool hassWifi) : this(microchip)
        {
            HasWifi = hassWifi;
        }

        public Robot(string microchip, bool hassWifi, string color) : this(microchip, hassWifi)
        {
            Color = color;
        }

        public Robot(string microchip, bool hassWifi, string color, int wheels) : this(microchip, hassWifi, color)
        {
            Wheels = wheels;
        }

        public Robot(string microchip, bool hassWifi, string color, int wheels, double cleaningrobot) : this(microchip, hassWifi, color, wheels)
        {
            CleaningRobot = cleaningrobot;
        }

        public Robot(string microchip, bool hassWifi, string color, int wheels, double cleaningrobot, int battery) : this(microchip, hassWifi, color, wheels, cleaningrobot)
        {
            Battery = battery;
        }
    }
}