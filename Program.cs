using System;
using SensoringGuard.Actuators;
using SensoringGuard.Triggers;
using SensoringGuard.Sensors;
using SensoringGuard.Automations;

namespace SensoringGuard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the new Home Assistant");

            TemperatureSensor waterTemperature = new TemperatureSensor();
            UltrasoneSensor waterLevel = new UltrasoneSensor();

            Alarm alarm = new Alarm(50);
            Led poolLed = new Led("green");
            Heater poolHeater = new Heater();
            Pump pump = new Pump();

            Automation pool = new Automation();
            pool.AddTrigger(new BelowTrigger(waterTemperature, 20), poolHeater);
            pool.AddTrigger(new AboveTrigger(waterTemperature, 20), poolLed);
            pool.AddTrigger(new AboveTrigger(waterTemperature, 35), alarm);
            pool.AddTrigger(new AboveTrigger(waterLevel, 2), pump);

            Console.WriteLine("Press any key for next update and double ESC for exit");
            while (Console.ReadKey().Key != ConsoleKey.Escape) {
              // Update sensors
              waterTemperature.Update();
              waterLevel.Update();
              
              // Thread.Sleep(1000);
              pool.Update();
              Console.WriteLine(pool);
              Console.WriteLine("----------------------------------------");
            }
            
        }
    }
}