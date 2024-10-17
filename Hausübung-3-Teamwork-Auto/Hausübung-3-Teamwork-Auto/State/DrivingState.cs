namespace Hausübung_3_Teamwork_Auto.State;

public class DrivingState : ICarState {
    
    public void Accelerate(AVehicle vehicle) {
        vehicle.AccelerateAction(vehicle);
    }

    public void Brake(AVehicle vehicle) {
        vehicle.BreakAction(vehicle);
    }

    public void SetMaintenance(AVehicle vehicle) {
        Console.WriteLine("Na nix, während fahren gibts ka reperatur oida.");
    }

    public void Park(AVehicle vehicle) {
        Console.WriteLine("parkplotz wird gsuacht");
        vehicle.CurrentCarState = new ParkedState();
        vehicle.Speed = 0;
    }

    public override bool Equals(object? obj) {
        return this.GetType() == obj.GetType();
    }
}