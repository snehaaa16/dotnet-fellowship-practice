using System;

namespace _08_Inheritance
{
    internal class SmartHomeDevices
    {
        public int DeviceId;
        public string Status;

        public SmartHomeDevices(int DeviceId, string Status)
        {
            this.DeviceId = DeviceId;
            this.Status = Status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine("Device ID : " + DeviceId);
            Console.WriteLine("Status : " + Status);
        }
    }

    internal class Thermostat : SmartHomeDevices
    {
        public int TemperatureSetting;

        public Thermostat(int DeviceId, string Status, int TemperatureSetting)
            : base(DeviceId, Status)
        {
            this.TemperatureSetting = TemperatureSetting;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Temperature : " + TemperatureSetting + "°C");
        }
    }
}