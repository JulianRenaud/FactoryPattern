using FactoryPattern;

Console.WriteLine("How many wheels would you like on your vehicle?");
var userInput = Console.ReadLine();
VehicleFactory.GetVehicle(userInput);


