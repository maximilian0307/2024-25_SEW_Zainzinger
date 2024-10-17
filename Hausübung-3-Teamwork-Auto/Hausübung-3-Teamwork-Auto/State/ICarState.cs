namespace Hausübung_3_Teamwork_Auto.State;

public interface ICarState {

    void Accelerate(AVehicle vehicle);
    void Brake(AVehicle vehicle);

    void SetMaintenance(AVehicle vehicle);
    void Park(AVehicle vehicle);
    
}