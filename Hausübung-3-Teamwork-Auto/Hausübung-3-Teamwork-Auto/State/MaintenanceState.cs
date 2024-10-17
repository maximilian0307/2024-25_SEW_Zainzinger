namespace Hausübung_3_Teamwork_Auto.State;

public class MaintenanceState : ICarState {
    
    public void Accelerate(AVehicle vehicle) {
        Console.WriteLine("na nix mit beschleunigen, vehicle is in da werkstatt");
    }

    public void Brake(AVehicle vehicle) {
        Console.WriteLine("na nix mit bremsen, vehicle is in da werkstatt");
    }

    public void SetMaintenance(AVehicle vehicle) {
        Console.WriteLine("Des auto wird eh scho repariert.");
    }

    public void Park(AVehicle vehicle) {
        Console.WriteLine("auto nochm reparieren parken is a guade idee");
    }
    
    public override bool Equals(object? obj) {
        return this.GetType() == obj.GetType();
    }
}