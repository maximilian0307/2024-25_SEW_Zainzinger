namespace MarsMission;

public class Sentinel {
    public static readonly SemaphoreSlim SentinelGuard = new SemaphoreSlim(0);
    public string Code { get; set; }
    public Sentinel(string code) {
        Code = code;
    }
    public void Run() {
        while (true) {
            ScanningSurface();
            Signal();
            Harvester.HarvestGuard.Release();
            Harvester.SignalHandshake.Wait();
        }
    }

    private void ScanningSurface() {
        Console.WriteLine($"{Code}: scanning surface");
        Thread.Sleep(500);
    }
    private void Signal() {
        Thread.Sleep(800);
        Console.WriteLine($"{Code}: Found raw material");
    }
}