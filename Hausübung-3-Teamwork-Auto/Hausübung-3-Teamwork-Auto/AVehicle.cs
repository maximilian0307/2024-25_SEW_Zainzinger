using Hausübung_3_Teamwork_Auto.Behaviours.Drive;
using Hausübung_3_Teamwork_Auto.State;

namespace Hausübung_3_Teamwork_Auto;

public abstract class AVehicle {

    public string Model { get; set; }

    public int Speed { get; set; }

    public IDriveBehaviour DriveBehaviour { get; set; }

    public ICarState CurrentCarState { get; set; }
    
    public Action<AVehicle> AccelerateAction;
    public Action<AVehicle> BreakAction;
    

    public AVehicle(string model, int speed, IDriveBehaviour driveBehaviour) {
        this.Model = model;
        this.Speed = speed;
        this.CurrentCarState = new ParkedState();
    }

    public void Accelerate() => CurrentCarState.Accelerate(this);

    public void Brake() => CurrentCarState.Brake(this);

    public void SetMaintenance() => CurrentCarState.SetMaintenance(this);

    public void Park() => CurrentCarState.Park(this);

}