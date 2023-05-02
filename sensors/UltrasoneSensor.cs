namespace SensoringGuard.Sensors {
  public class UltrasoneSensor : ISensor {

    public void Update() {
      value = generator.NextDouble() * 3;
    }

    public double GetValue() {
      return value;
    }

    public override string ToString()
    {
      return "The distance is " + string.Format("{0:N2}", GetValue());
    }

    private Random generator = new Random();
    private double value = 0;
  }
}