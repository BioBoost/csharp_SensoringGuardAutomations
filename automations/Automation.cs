using SensoringGuard.Actuators;
using SensoringGuard.Triggers;

namespace SensoringGuard.Automations {
  public class Automation {

    public void AddTrigger(Trigger trigger, Actuator actuator) {
      conditions.Add(trigger, actuator);
    }

    public override string ToString()
    {
      string output = "";

      foreach (var condition in conditions)
      {
        output += $"{condition.Key} => {condition.Value}\n";
      }

      return output;
    }

    public void Update() {
      foreach (var condition in conditions)
      {
        if (condition.Key.IsTrue()) {
          condition.Value.On();
        } else {
          condition.Value.Off();
        }
      }
    }

    private Dictionary<Trigger,Actuator> conditions = new Dictionary<Trigger, Actuator>();

  }
}