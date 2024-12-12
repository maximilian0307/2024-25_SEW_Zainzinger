namespace KebsBaba;

public class Cashier {
    public static readonly SemaphoreSlim CashierGuard = new SemaphoreSlim(0);
    public string Name { get; set; }
    
    public Cashier(string name) {
        Name = name;
    }

    public void Run() {
        CashierGuard.Wait();
        while (true) {
            Confirm();
            Customer.CustomerGuard.Release();
            CashierGuard.Wait();
        }
    }
    public void Confirm() {
        Console.WriteLine($"{Name}: confirm payment");
        Thread.Sleep(1818);
    }
}