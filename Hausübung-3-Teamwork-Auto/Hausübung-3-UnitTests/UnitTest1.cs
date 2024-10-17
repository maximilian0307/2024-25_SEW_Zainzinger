using Hausübung_3_Teamwork_Auto;
using Hausübung_3_Teamwork_Auto.Behaviours.Drive;
using Hausübung_3_Teamwork_Auto.Types;

namespace Hausübung_3_UnitTests;

public class Tests {
    [SetUp]
    public void Setup() {
    }

    [Test]
    public void TestState() {
        Car car = new Car("Ford", 100, new NormalDriveBehaviour());

        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Car model: {car.Model}");
        Console.WriteLine($"Car speed: {car.Speed}");
        Console.WriteLine($"Current State: {car.CurrentCarState}");
        Console.WriteLine("----------------------------------");
        
        car.Brake();
        car.Accelerate();
        car.Brake();
        
        Motorcycle motorcycle = new Motorcycle("kawasaki", 500, new SportDriveBehaviour());
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Motorcycle model: {motorcycle.Model}");
        Console.WriteLine($"Motorcycle speed: {motorcycle.Speed}");
        Console.WriteLine($"Current State: {motorcycle.CurrentCarState}");
        Console.WriteLine("----------------------------------");
        
        motorcycle.Brake();
        motorcycle.Accelerate();
        motorcycle.Brake();
    }
    
    [Test]
    public void TestMaintenanceState() {
        Truck truck = new Truck("MAN", 80, new EnergyEfficientDriveBehaviour());

        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Truck model: {truck.Model}");
        Console.WriteLine($"Truck speed: {truck.Speed}");
        Console.WriteLine($"Current State: {truck.CurrentCarState}");
        Console.WriteLine("----------------------------------");
        
        truck.Accelerate();
        truck.Brake();
        truck.Park();
        truck.SetMaintenance();
        
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Current State: {truck.CurrentCarState}");
        Console.WriteLine("----------------------------------");
    }
}