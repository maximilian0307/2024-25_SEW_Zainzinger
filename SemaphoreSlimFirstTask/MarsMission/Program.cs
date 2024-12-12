namespace MarsMission;

class Program {
    static void Main(string[] args) {
        new Thread(new Sentinel("Sentinel1").Run).Start();
        new Thread(new Sentinel("Sentinel2").Run).Start();
        new Thread(new Harvester("Harvester1").Run).Start();
        new Thread(new Harvester("Harvester2").Run).Start();
        new Thread(new Harvester("Harvester3").Run).Start();
        new Thread(new Harvester("Harvester4").Run).Start();
    }
}