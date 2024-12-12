namespace KebsBaba;

class Program {
    static void Main(string[] args) {
        new Thread(new Cook("Abdul").Run).Start();
        new Thread(new Cook("Hakan").Run).Start();
        new Thread(new Cashier("Ali").Run).Start();
        new Thread(new Customer("Hofbauer").Run).Start();
        new Thread(new Customer("Christoph").Run).Start();
        new Thread(new Customer("Marcus").Run).Start();
    }
}