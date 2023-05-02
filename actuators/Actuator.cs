namespace SensoringGuard.Actuators {
  public class Actuator {
    public bool IsOn { get; set; }

    public void On() {
      IsOn = true;
    }

    public void Off() {
      IsOn = false;
    }
  }
}