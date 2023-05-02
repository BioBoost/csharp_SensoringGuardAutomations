namespace SensoringGuard.Actuators {
  public class Alarm : Actuator {
    public int Volume { get; set; }

    public Alarm(int volume) {
      Volume = volume;
    }

    public override string ToString()
    {
      return "The alarm is " + (IsOn ? "on" : "off");
    }
  }
}