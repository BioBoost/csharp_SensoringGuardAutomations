using SensoringGuard.Sensors;

namespace SensoringGuard.Triggers {
  public abstract class Trigger {

    protected ISensor Sensor { get; set; }

    public abstract bool IsTrue();

  }
}