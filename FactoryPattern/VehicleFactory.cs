using FactoryPattern.NewFolder;
using FactoryPattern.Vehicles;
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
                case "2":
                    IVehicle v1 = new Motorcycle();
                    v1.Drive();
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(" .");
                    }
                    v1.Built();
                    return new Motorcycle();
                case "3":
                case "three":
                    IVehicle v2 = new MotorTricycle();
                    v2.Drive();
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(" .");
                    }
                    v2.Built();
                    return new MotorTricycle();
                case "4":
                case "four":
                    IVehicle v3 = new Car();
                    v3.Drive(); 
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(" .");
                    }
                    v3.Built();
                    return new Car();
                case "6":
                case "six":
                    IVehicle v4 = new HeavyDuty();
                    v4.Drive();
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(" .");
                    }
                    v4.Built();
                    return new HeavyDuty();
                case "8":
                case "eight":
                    IVehicle v5 = new ReallyHeavyDuty();
                    v5.Drive();
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(" .");
                    }
                    v5.Built();
                    return new ReallyHeavyDuty();
                case "12":
                case "twelve":
                    IVehicle v6 = new PickUp();
                    v6.Drive();
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(" .");
                    }
                    v6.Built();
                    return new PickUp();
                case "18":
                case "eighteen":
                    IVehicle v7 = new An18Wheeler();
                    v7.Drive();
                    for (int i = 0; i < 4; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(" .");
                    }
                    v7.Built();
                    return new An18Wheeler();

                default:
                    Console.WriteLine("Sorry, we do not have a vehicle with that specific ammount of wheels in stock today!");
                    return null;
            }

        }
    }
}
