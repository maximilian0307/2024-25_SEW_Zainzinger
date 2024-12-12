namespace KebsBaba;

public class Cook {
    public static readonly SemaphoreSlim CookGuard = new SemaphoreSlim(0);

    public string Name { get; set; }
    
    public Cook(string name) {
        Name = name;
    }

    public void Run() {
        CookGuard.Wait();
        while (true) {
            PrepareMeal();
            Customer.CustomerGuard.Release();
            CookGuard.Wait();
        }
    }
    public void PrepareMeal() {
        Console.WriteLine($"{Name} is cooking meal");
        Thread.Sleep(1818);
    }
}