using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string numOfWheels)
        {
            switch (numOfWheels.ToLower())
            {
                case "two":
                    var v1 = new Car();
                    v1.Drive();
                    return new Motorcycle();
                case "2":
                    var v2 = new Motorcycle();
                    v2.Drive();
                    return new Motorcycle();
                case "four":
                    var v3 = new Car();
                    v3.Drive();
                    return new Car();
                case "4":
                    var v4 = new Car();
                    v4.Drive();
                    return new Car();
                default:
                    Console.WriteLine("Sorry, we do not have a vehicle with that specific ammount of wheels in stock today!");
                    return null;
            }

        }
    }
}
