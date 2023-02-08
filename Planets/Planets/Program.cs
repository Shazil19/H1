using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Createsd a list for all the Planets (Venus is not Included)

            List<Planet> planets = new List<Planet>();
                        
            planets.Add(new Planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "No"));
            
            planets.Add(new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, "No"));
            
            planets.Add(new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, "No"));
            
            planets.Add(new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, "Yes"));
            
            planets.Add(new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, "Yes"));
            
            planets.Add(new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, "Yes"));
            
            planets.Add(new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 598, 5.4, -200, 14, "Yes"));
            
            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 9056, 4.7, -225, 5, "No"));

            //this will clear the main list and all other list won't work

            planets.Clear();

            //Console.WriteLine for all the Planets in the list right now (Venus is not in the list right now)

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.ToString());
            }

            //Inserting Planet Venus

            planets.Insert(1, new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, "No"));
            Console.WriteLine("\nPlanets Including Venus \n");

            //Console.WriteLine for all the Planets

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.ToString() + "\n");
            }

            Console.WriteLine("In August 2006, the International Astronomical Union declared that Pluto was no longer perceived as a planet" + "\n" + "Planets list without Pluto" + "\n");

            //Removing Planet Pluto from the list

            planets.RemoveAt(8);

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.ToString() + "\n");
            }

            //Included Planet Pluto again

            Console.WriteLine("Planet list Including Pluto\n");

            planets.Insert(8, new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 9056, 4.7, -225, 5, "No"));

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.ToString());
            }

            //Created a new list "planet1"

            //Console.WriteLine("This is the total amount of the planets in the list right now: "+planets.Count + "\n");

            List<Planet> planetT = new List<Planet>();

            //created a foreach loop to add all the planets (under the temperature of 0) into the new list 

            foreach (Planet item in planets)
            {
                if (item.meantemperature < 0)
                {
                    planetT.Add(item);
                }
            }

            //Console.WriteLine all the data from the new list

            foreach (Planet planet in planetT)
            {
                Console.WriteLine(planet.ToString());
            }

            //created a new list for all the planet with the diameter above 10000 km and below 50000 km

            List<Planet> planetD = new List<Planet>();

            foreach (Planet items in planets)
            {
                if (items.diameter > 10000 && items.diameter < 50000)
                {
                    planetD.Add(items);
                }
            }

            //Console.WriteLine all the data from the new list

            Console.WriteLine("Planets with diameter over 10000 and under 50000 km");

            foreach (Planet planet in planetD)
            {
                Console.WriteLine("______________________________");
                Console.WriteLine(planet.ToString());
            }


        }

        // new class for creating all the necessary objects we need

        public class Planet
        {

            //all the objects

            private string _name;

            private double _mass;

            private int _diameter;

            private int _density;

            private double _gavity;

            private double _rotationperiod;

            private double _daylength;

            private double _sundistance;

            private double _orbitalperiod;

            private double _orbitalvelocity;

            private double _meantemperature;

            private int _moon;

            private string _ringsystem;

            //making it public for the new lists

            public double meantemperature { get { return _meantemperature; } }

            public int diameter { get { return _diameter; } }

            //conductore for the program

            public Planet
                (
                    string name, 
                    double mass, 
                    int diameter, 
                    int density, 
                    double gavity, 
                    double rotationperiod, 
                    double daylength, 
                    double sundistance,
                    double orbitalperiod, 
                    double orbitalvelocity, 
                    double meantemperature, 
                    int moon, 
                    string ringsystem

                )
            {
                _name = name;
                _mass = mass;
                _diameter = diameter;
                _density = density;
                _gavity = gavity;
                _rotationperiod = rotationperiod;
                _daylength = daylength;
                _sundistance = sundistance;
                _orbitalperiod = orbitalperiod;
                _orbitalvelocity = orbitalvelocity;
                _meantemperature = meantemperature;
                _moon = moon;
                _ringsystem = ringsystem;
            }

            //overriding the objects.
            public override string ToString()
            {
                return
                    "Planet name: " + _name + " Mass: " +
                    _mass + " Diameter: " +
                    _diameter + " Density: " +
                    _density + " Gravity: " +
                    _gavity + " RotationPeriod: " +
                    _rotationperiod + " Daylenght: " + "\n" +
                    _daylength + " SunDistance: " +
                    _sundistance + " OrbitalPeriod: " +
                    _orbitalperiod + " OrbitalVelocity: " +
                    _orbitalvelocity + " MeanTemperature: " +
                    _meantemperature + " Moon: " +
                    _moon + " RingSystem: " +
                    _ringsystem + "\n";
            }
        }
    }
}
