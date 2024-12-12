namespace SemaphoreSlimFirstTask;

public class Crane {
    public static readonly SemaphoreSlim CraneGuard = new SemaphoreSlim(0);
    public void Run() {
        while (true) {
            Move("Storage", "MachineA");
            MachineA.MachineAGuard.Release();
            CraneGuard.Wait();
            Move("MachineA", "MachineB");
            MachineB.MachineBGuard.Release();
            CraneGuard.Wait();
            Move("MachineB", "Storage");
            Console.WriteLine("...");
        }
    }

    private void Move(string from, string to) {
        Thread.Sleep(200);
        Console.WriteLine($"moving from {from} to {to}");
    }
}