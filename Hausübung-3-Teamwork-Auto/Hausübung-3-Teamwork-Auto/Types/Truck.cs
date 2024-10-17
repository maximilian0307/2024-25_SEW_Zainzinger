using Hausübung_3_Teamwork_Auto.Behaviours;
using Hausübung_3_Teamwork_Auto.Behaviours.Drive;
using Hausübung_3_Teamwork_Auto.Commands;

namespace Hausübung_3_Teamwork_Auto.Types;

public class Truck : AVehicle {
    
    public Truck(string model, int speed, IDriveBehaviour driveBehaviour) : base(model, speed, driveBehaviour) {
        AccelerateAction = (vehicle) => {
            vehicle.Speed += 10;
            new AccelerateCommand(new TruckAccelerateBehaviour()).Execute(vehicle);
        };

        BreakAction = (vehicle) => {
            vehicle.Speed -= 5;
            new BreakCommand(new TruckBreakBehaviour()).Execute(vehicle);
        };
    }
    
    public Truck() : this(String.Empty, 0, new NormalDriveBehaviour()){
        
    }
    
}