namespace SemaphoreSlimFirstTask;

public class MachineA {
    public static readonly SemaphoreSlim MachineAGuard = new SemaphoreSlim(0);
    public void Run() {
        MachineAGuard.Wait();
        while (true) {
            Process();
            Crane.CraneGuard.Release();
            MachineAGuard.Wait();    
        }
      }

    private void Process() {
        Thread.Sleep(100);
        Console.WriteLine("MachineA: finished work");
    }
}