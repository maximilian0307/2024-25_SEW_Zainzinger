namespace Hausübung_3_Teamwork_Auto.Behaviours.Drive;

public class NormalDriveBehaviour : IDriveBehaviour {
    public string PerformDrive() {
        return "foi normal";
    }
    
    public override bool Equals(object? obj) {
        return this.GetType() == obj.GetType();
    }
}