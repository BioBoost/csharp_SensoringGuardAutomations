using SensoringGuard.Sensors;

namespace SensoringGuard.Triggers {
  public class AboveTrigger : Trigger {

    public double Threshold { get; set; }

    public AboveTrigger(ISensor sensor, double threshold) {
      Sensor = sensor;
      Threshold = threshold;
    }

    public override bool IsTrue() {
      return Sensor.GetValue() > Threshold;
    }

    public override string ToString()
    {
      return $"[{Sensor}]>{Threshold}? {IsTrue()}";
    }

  }
}