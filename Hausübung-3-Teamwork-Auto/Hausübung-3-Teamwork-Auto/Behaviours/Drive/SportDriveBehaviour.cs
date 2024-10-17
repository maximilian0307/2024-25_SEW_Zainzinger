namespace Hausübung_3_Teamwork_Auto.Behaviours.Drive;

public class SportDriveBehaviour : IDriveBehaviour {
    public string PerformDrive() {
        return "foi sportlich";
    }
    
    public override bool Equals(object? obj) {
        return this.GetType() == obj.GetType();
    }
}