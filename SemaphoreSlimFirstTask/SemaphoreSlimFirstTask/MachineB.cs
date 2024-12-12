namespace SemaphoreSlimFirstTask;

public class MachineB {
    public static readonly SemaphoreSlim MachineBGuard = new SemaphoreSlim(0);
    public void Run() {
        MachineBGuard.Wait();
        while (true) {
            Process();
            Crane.CraneGuard.Release();
            MachineBGuard.Wait();
        }
    }

    private void Process() {
        Thread.Sleep(100);
        Console.WriteLine("MachineB: finished work");
    }
}