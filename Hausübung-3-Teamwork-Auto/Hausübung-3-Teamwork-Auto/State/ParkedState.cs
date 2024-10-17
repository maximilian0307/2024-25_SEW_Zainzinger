namespace Hausübung_3_Teamwork_Auto.State;

public class ParkedState : ICarState {

    public void Accelerate(AVehicle vehicle) {
        vehicle.AccelerateAction(vehicle);
        vehicle.CurrentCarState = new DrivingState();
    }

    public void Brake(AVehicle vehicle) {
        Console.WriteLine("na nix, beim parken bremsen is unnötig");
    }

    public void SetMaintenance(AVehicle vehicle) {
        Console.WriteLine("wird repariert...");
        vehicle.CurrentCarState = new MaintenanceState();
    }

    public void Park(AVehicle vehicle) {
        Console.WriteLine("i park eh scho");
    }
    
    public override bool Equals(object? obj) {
        return this.GetType() == obj.GetType();
    }
}