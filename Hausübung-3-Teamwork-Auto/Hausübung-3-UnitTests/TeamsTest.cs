using Hausübung_3_Teamwork_Auto;
using Hausübung_3_Teamwork_Auto.Behaviours.Drive;
using Hausübung_3_Teamwork_Auto.State;

namespace Hausübung_3_UnitTests;

public class TeamsTest {
    
    [SetUp]
    public void Setup() {
    }
    
    [Test]
        public void TruckAccelerateAndBrake() {
            // Arrange
            var truck = VehicleFactory.Instance.CreateTruck();
            truck.Park();  // Initial state: Parked
            
            // Act
            truck.Accelerate();  // Accelerate to 30 km/h
            truck.Accelerate();
            truck.Accelerate();
            truck.Brake();  // Brake 3 times
            truck.Brake();
            truck.Brake();

            // Assert
            Assert.AreEqual(15, truck.Speed);  // Final speed should be 15 km/h
        }

        [Test]
        public void CarAccelerateAndBrake() {
            // Arrange
            var car = VehicleFactory.Instance.CreateStandardCar();
            car.Park();  // Initial state: Parked

            // Act
            car.Accelerate();  // Accelerate to 50 km/h
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Brake();  // Brake 3 times
            car.Brake();
            car.Brake();

            // Assert
            Assert.AreEqual(35, car.Speed);  // Final speed should be 35 km/h
        }

        [Test]
        public void MotorcycleSportModeAccelerateAndBrake() {
            // Arrange
            var motorcycle = VehicleFactory.Instance.CreateMotorcycle();
            motorcycle.Park();  // Initial state: Parked

            // Act
            motorcycle.DriveBehaviour = new SportDriveBehaviour();  // Switch to sport strategy
            motorcycle.Accelerate();
            motorcycle.Brake();
            motorcycle.Brake();

            // Assert
            Assert.AreEqual(0, motorcycle.Speed);  // Final speed should be 0 km/h
        }

        [Test]
        public void CarEcoModeAccelerateAndBrake() {
            // Arrange
            var ecoCar = VehicleFactory.Instance.CreateEcoCar();
            ecoCar.Park();  // Initial state: Parked

            // Act
            for (int i = 0; i < 8; i++) {
                ecoCar.Accelerate();
            }
            for (int i = 0; i < 4; i++) {
                ecoCar.Brake();
            }

            // Assert
            Assert.AreEqual(60, ecoCar.Speed);  // Final speed should be 60 km/h
        }

        [Test]
        public void TruckSportModeAccelerateAndBrake() {
            // Arrange
            var sportTruck = VehicleFactory.Instance.CreateSportTruck();
            sportTruck.Park();  // Initial state: Parked

            // Act
            sportTruck.DriveBehaviour = new SportDriveBehaviour();  // Switch to sport strategy
            for (int i = 0; i < 5; i++) {
                sportTruck.Accelerate();
            }
            for (int i = 0; i < 3; i++) {
                sportTruck.Brake();
            }

            // Assert
            Assert.AreEqual(35, sportTruck.Speed);  // Final speed should be 35 km/h
        }

        [Test]
        public void CarNormalModeStateChange() {
            // Arrange
            var car = VehicleFactory.Instance.CreateStandardCar();
            car.Park();  // Initial state: Parked

            // Act & Assert
            Assert.AreEqual(new ParkedState(), car.CurrentCarState);
            car.Accelerate(); // Switching State
            Assert.AreEqual(new DrivingState(), car.CurrentCarState);

            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();

            // Assert
            Assert.AreEqual(50, car.Speed);  // Final speed should be 40 km/h
        }

        [Test]
        public void MotorcycleEcoModeAccelerateAndBrake() {
            // Arrange
            var motorcycle = VehicleFactory.Instance.CreateMotorcycle();
            motorcycle.Park();  // Initial state: Parked

            // Act
            Assert.AreEqual(new ParkedState(), motorcycle.CurrentCarState);
            motorcycle.DriveBehaviour = new EnergyEfficientDriveBehaviour();  // Switch to eco strategy
            Assert.AreEqual(new EnergyEfficientDriveBehaviour(), motorcycle.DriveBehaviour);
            for (int i = 0; i < 6; i++) {
                motorcycle.Accelerate();
            }
            for (int i = 0; i < 2; i++) {
                motorcycle.Brake();
            }
            Assert.AreEqual(new DrivingState(), motorcycle.CurrentCarState);

            // Assert
            Assert.AreEqual(50, motorcycle.Speed);  // Final speed should be 50 km/h
        }

        [Test]
        public void CheckStateTransitions() {
            // Arrange
            var car = VehicleFactory.Instance.CreateStandardCar();
            car.Park();  // Initial state: Parked

            // Act
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            
            // Park, because no maintenance can be done while driving
            car.Park();
            Assert.AreEqual(new ParkedState(), car.CurrentCarState);
            
            // Switch to maintenance
            car.SetMaintenance();
            Assert.AreEqual(new MaintenanceState(), car.CurrentCarState);
            
            car.Accelerate();  // Attempt to accelerate

            // Assert
            Assert.AreEqual(0, car.Speed);  // Final Speed should be 0, because it is parked in maintenance
        }
}