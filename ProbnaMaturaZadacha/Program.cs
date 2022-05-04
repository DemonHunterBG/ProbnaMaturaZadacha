using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProbnaMaturaZadacha
{
    class Program
    {
        private static List<string> vehicles = new List<string>();

        static void Main(string[] args)
        {
            Read();
            Write();
        }
        static void Read()
        {
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "1")
                    {
                        Car car = new Car();
                        car.Brand = reader.ReadLine();
                        List<string> info = reader.ReadLine().Split(" ").ToList();
                        car.Year = int.Parse(info[0]);
                        car.Mileage = int.Parse(info[1]);
                        car.Value = double.Parse(info[2]);

                        string outcome = $"{car.Brand}: {car.Mileage} km, {Math.Round(car.Price(), 2):F2}";
                        vehicles.Add(outcome);
                    }
                    else if (line == "2")
                    {
                        Truck truck = new Truck();
                        truck.Brand = reader.ReadLine();
                        List<string> info = reader.ReadLine().Split(" ").ToList();
                        truck.Year = int.Parse(info[0]);
                        truck.Mileage = int.Parse(info[1]);
                        truck.Value = double.Parse(info[2]);
                        truck.Tonnage = int.Parse(info[3]);

                        string outcome = $"{truck.Brand}: {truck.Mileage} km, {Math.Round(truck.Price(), 2):F2}";
                        vehicles.Add(outcome);
                    }
                }
            }
        }

        static void Write()
        {
            vehicles.Reverse();
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
