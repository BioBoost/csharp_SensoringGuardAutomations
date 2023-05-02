namespace SensoringGuard.Actuators {
  public class Led : Actuator {
    public string Color { get; set; }

    public Led(string color) {
      Color = color;
    }

    public override string ToString()
    {
      return $"The {Color} LED is " + (IsOn ? "on" : "off");
    }
  }
}