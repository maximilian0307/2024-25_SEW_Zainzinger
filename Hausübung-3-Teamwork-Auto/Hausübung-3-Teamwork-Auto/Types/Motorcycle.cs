using Hausübung_3_Teamwork_Auto.Behaviours;
using Hausübung_3_Teamwork_Auto.Behaviours.Drive;
using Hausübung_3_Teamwork_Auto.Commands;

namespace Hausübung_3_Teamwork_Auto.Types;

public class Motorcycle : AVehicle {
    
    public Motorcycle(string model, int speed, IDriveBehaviour driveBehaviour) : base(model, speed, driveBehaviour) {
        AccelerateAction = (vehicle) => {
            vehicle.Speed += 10;
            new AccelerateCommand(new MotorcycleAccelerateBehaviour()).Execute(vehicle);
        };
        
        BreakAction = (vehicle) => {
            vehicle.Speed -= 5;
            new BreakCommand(new MotorcycleBreakBehaviour()).Execute(vehicle);
        };
    }
    
    public Motorcycle() : this(String.Empty, 0, new NormalDriveBehaviour()){
        
    }

}