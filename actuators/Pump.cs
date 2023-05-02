namespace SensoringGuard.Actuators {
  public class Pump : Actuator {

    public Pump() {
    }

    public override string ToString()
    {
      return "The pump is " + (IsOn ? "on" : "off");
    }
  }
}