namespace Hausübung_3_Teamwork_Auto.Commands;

public class BreakCommand : IVehicleCommand {

    private IBreakBehaviour _breakBehaviour;
    
    public BreakCommand(IBreakBehaviour breakBehaviour) {
        _breakBehaviour = breakBehaviour;
    }
    
    public void Execute(AVehicle vehicle) {
        Console.WriteLine("oida i BREEEEEMS!!! Behaviour: " + _breakBehaviour.PerformBreak());
    }
}