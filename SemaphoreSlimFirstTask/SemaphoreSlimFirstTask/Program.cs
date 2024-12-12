namespace SemaphoreSlimFirstTask;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Factory - Crane");
        Thread ma = new Thread(new MachineA().Run);
        Thread mb = new Thread(new MachineB().Run);
        Thread crane = new Thread(new Crane().Run);
        ma.Start();
        mb.Start();
        crane.Start();
    }
}

class NightClubSemaphore {
    
    static SemaphoreSlim sem = new SemaphoreSlim(3);
    static void Enter(object id) {
        Console.WriteLine(id + " wants to enter");
        sem.Wait();
        Console.WriteLine(id + " is in!");
        Thread.Sleep(1000* (int)id);
        Console.WriteLine(id + " is leaving");
        sem.Release();
    }
    public static void TestSemaphore() {
        for (int i = 1; i <= 5; i++) {
            new Thread(Enter).Start(i);
        }
    }
}

class SemaphoreDemo {
    public static Semaphore threadPool = new Semaphore(3, 5);

    private static void PerformSomeWork() {
        threadPool.WaitOne();
        Console.WriteLine("Thread {0} is inside the critical selection...", Thread.CurrentThread.Name);
        Thread.Sleep(10000);
        threadPool.Release();
    }
    public static void TestSemaphore() {
        for (int i = 0; i < 10; i++) {
            Thread t = new Thread(new ThreadStart(PerformSomeWork));
            t.Name = "Thread Name: " + i;
            t.Start();
        }
    }
}