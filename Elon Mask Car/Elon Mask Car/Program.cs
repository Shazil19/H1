using System;

namespace Elon_Mask_car
{
    public class Car
    {
        private string _color;
        private int _distanceDriven;
        private int _batteryPercentage;

        // Property to get and set the color of the car
        public string Color
        {
            get { return _color; }
            private set { _color = value; }
        }

        // Property to get and set the distance driven by the car
        public int DistanceDriven
        {
            get { return _distanceDriven; }
            private set { _distanceDriven = value; }
        }

        // Property to get and set the battery percentage of the car
        public int BatteryPercentage
        {
            get { return _batteryPercentage; }
            private set { _batteryPercentage = value; }
        }

        // Constructor to initialize the car object
        public Car(string color)
        {
            _color = color;
            _distanceDriven = 0;
            _batteryPercentage = 100;
        }

        // Method to drive the car
        public void Drive()
        {
            if (_batteryPercentage == 0)
            {
                Console.WriteLine("The car cannot drive as the battery is empty.");
            }
            else
            {
                _distanceDriven += 20;
                _batteryPercentage -= 1;
                Console.WriteLine("The car has driven 20 meters and the battery percentage is now " + _batteryPercentage + "%");
            }
        }

        // Method to charge the car
        public void Charge()
        {
            _distanceDriven = 0;
            _batteryPercentage = 100;
            Console.WriteLine("The car has been charged and the battery percentage is now " + _batteryPercentage + "%");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating two car objects
            Car car1 = new Car("Red");
            Car car2 = new Car("Yellow");

            // Looping through the cars until the battery is empty
            while (car1.BatteryPercentage != 0 && car2.BatteryPercentage != 0)
            {
                Console.WriteLine("Choose a car (1 or 2) to drive:");
                int carChoice = int.Parse(Console.ReadLine());

                if (carChoice == 1)
                {
                    car1.Drive();
                }
                else if (carChoice == 2)
                {
                    car2.Drive();
                }
            }

            Console.WriteLine("Both cars cannot drive anymore.");
            Console.ReadLine();
        }
    }
}