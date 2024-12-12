using System.Security.Cryptography.X509Certificates;

namespace MarsMission;

public class Harvester {
    public static readonly SemaphoreSlim HarvestGuard = new SemaphoreSlim(0);
    public static readonly SemaphoreSlim SignalHandshake = new SemaphoreSlim(0);
    public static readonly SemaphoreSlim StorageGuard = new SemaphoreSlim(2);
    public string Code { get; set; }
    public Harvester(string code) {
        Code = code;
    }
    public void Run() {
        while (true) {
            HarvestGuard.Wait();
            Acknowledge();
            SignalHandshake.Release();         
            Harvest(); 
            
            StorageGuard.Wait();
            Store();
            StorageGuard.Release();
        }
    }
    private void Acknowledge() {
        Console.WriteLine($"{Code}: Acknowledging Signal");
        Thread.Sleep(100);
    }
    private void Harvest() {
        Console.WriteLine($"{Code}: Harvesting resources");
        Thread.Sleep(1000);
    }
    private void Store() {
        Console.WriteLine($"{Code}: Storing resources");
        Thread.Sleep(200);
    }
}