using Hausübung_3_Teamwork_Auto.Behaviours;
using Hausübung_3_Teamwork_Auto.Behaviours.Drive;
using Hausübung_3_Teamwork_Auto.Commands;

namespace Hausübung_3_Teamwork_Auto.Types;

public class Car : AVehicle {
    
    public Car(string model, int speed, IDriveBehaviour driveBehaviour) : base(model, speed, driveBehaviour) {
        AccelerateAction = (vehicle) => {
            vehicle.Speed += 10;
            new AccelerateCommand(new CarAccelerateBehaviour()).Execute(vehicle);
        };

        BreakAction = (vehicle) => {
            vehicle.Speed -= 5;
            new BreakCommand(new CarBreakBehaviour()).Execute(vehicle);
        };
    }

    public Car() : this(String.Empty, 0, new NormalDriveBehaviour()){
        
    }
    
}