namespace SensoringGuard.Actuators {
  public class Heater : Actuator {

    public Heater() {
    }

    public override string ToString()
    {
      return "The heater is " + (IsOn ? "on" : "off");
    }
  }
}