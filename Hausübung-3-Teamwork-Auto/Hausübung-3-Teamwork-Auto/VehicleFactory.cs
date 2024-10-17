using Hausübung_3_Teamwork_Auto.Behaviours.Drive;
using Hausübung_3_Teamwork_Auto.State;
using Hausübung_3_Teamwork_Auto.Types;

namespace Hausübung_3_Teamwork_Auto;

public class VehicleFactory {

    private static VehicleFactory _instance;

    public static VehicleFactory Instance {
        get {
            if (_instance == null) {
                _instance = new VehicleFactory();
                return _instance;
            }

            return _instance;
        }
    }

    public Car CreateStandardCar() {
        return new VehicleBuilder<Car>()
            .SetModel("Standard Car")
            .SetSpeed(0)
            .SetDrivingStrategy(new NormalDriveBehaviour())
            .SetState(new ParkedState())
            .Build();
    }
    
    public Truck CreateTruck() {
        return new VehicleBuilder<Truck>()
            .SetModel("Heavy Truck")
            .SetSpeed(0)
            .SetDrivingStrategy(new NormalDriveBehaviour())
            .SetState(new ParkedState())
            .Build();
    }
    
    public Motorcycle CreateMotorcycle() {
        return new VehicleBuilder<Motorcycle>()
            .SetModel("Sport Motorcycle")
            .SetSpeed(0)
            .SetDrivingStrategy(new SportDriveBehaviour())
            .SetState(new ParkedState())
            .Build();
    }
    
    public Car CreateEcoCar() {
        return new VehicleBuilder<Car>()
            .SetModel("Eco Car")
            .SetSpeed(0)
            .SetDrivingStrategy(new EnergyEfficientDriveBehaviour())
            .SetState(new ParkedState())
            .Build();
    }
    
    public Truck CreateSportTruck() {
        return new VehicleBuilder<Truck>()
            .SetModel("Sport Truck")
            .SetSpeed(0)
            .SetDrivingStrategy(new SportDriveBehaviour())
            .SetState(new ParkedState())
            .Build();
    }
}