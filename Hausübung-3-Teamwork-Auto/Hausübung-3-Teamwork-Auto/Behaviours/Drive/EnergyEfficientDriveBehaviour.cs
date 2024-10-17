namespace Hausübung_3_Teamwork_Auto.Behaviours.Drive;

public class EnergyEfficientDriveBehaviour : IDriveBehaviour {
    public string PerformDrive() {
        return "foi energieeffizient";
    }
    
    public override bool Equals(object? obj) {
        return this.GetType() == obj.GetType();
    }
}