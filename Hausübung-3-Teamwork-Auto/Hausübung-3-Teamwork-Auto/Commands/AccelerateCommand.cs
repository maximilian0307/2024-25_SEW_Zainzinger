namespace Hausübung_3_Teamwork_Auto.Commands;

public class AccelerateCommand : IVehicleCommand {

    private IAccelerateBehaviour _accelerateBehaviour;

    public AccelerateCommand(IAccelerateBehaviour accelerateBehaviour) {
        _accelerateBehaviour = accelerateBehaviour;
    }
    
    public void Execute(AVehicle vehicle) {
        Console.WriteLine("oida i beschleinig jz amoi Behaviour: " + _accelerateBehaviour.PerformAccelerate());
    }
}