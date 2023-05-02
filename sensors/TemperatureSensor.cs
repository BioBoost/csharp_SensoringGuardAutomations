namespace SensoringGuard.Sensors {
  public class TemperatureSensor : ISensor {

    public void Update() {
      value = generator.NextDouble() * 50;
    }

    public double GetValue() {
      return value;
    }

    public override string ToString()
    {
      return "The temperature is " + string.Format("{0:N2}", GetValue());
    }

    private Random generator = new Random();
    private double value = 0;
  }
}