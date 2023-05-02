namespace SensoringGuard.Sensors {
  public interface ISensor {
    // Get the last updated value
    double GetValue();

    // Update the actual value (hardware)
    void Update();
  }
}