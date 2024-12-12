namespace KebsBaba;

public class Customer {
    public static readonly SemaphoreSlim CustomerGuard = new SemaphoreSlim(0);

    public string Name { get; set; }
    public Customer(string name) {
        Name = name;
    }
    public void Run() {
        while (true) {
            Order();
            Cook.CookGuard.Release();
            CustomerGuard.Wait();
            Pay();
            Cashier.CashierGuard.Release();
            CustomerGuard.Wait();
        }
    }
    private void Order() {
        Console.WriteLine($"{Name}: Ordering Food");
        Thread.Sleep(1917);
    }

    private void Pay() {
        Console.WriteLine($"{Name}: paying order");
        Thread.Sleep(1989);
    }
}