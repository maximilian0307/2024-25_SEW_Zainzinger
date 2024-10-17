using Hausübung_3_Teamwork_Auto.Behaviours.Drive;
using Hausübung_3_Teamwork_Auto.State;

namespace Hausübung_3_Teamwork_Auto;

public class VehicleBuilder<T> where T : AVehicle, new() {

    private T _vehicle;
    
    public VehicleBuilder() {
        _vehicle = new T();
    }

    public VehicleBuilder<T> SetModel(string model) {
        _vehicle.Model = model;
        return this;
    }
    
    public VehicleBuilder<T> SetSpeed(int speed) {
        _vehicle.Speed = speed;
        return this;
    }

    public VehicleBuilder<T> SetDrivingStrategy(IDriveBehaviour driveBehaviour) {
        _vehicle.DriveBehaviour = driveBehaviour;
        return this;
    }

    public VehicleBuilder<T> SetState(ICarState state) {
        _vehicle.CurrentCarState = state;
        return this;
    }

    public T Build() {
        return _vehicle;
    }

}