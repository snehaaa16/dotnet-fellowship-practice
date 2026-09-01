//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Practice
//{
//    public interface IConnectable
//    {
//        void WifiConnectivity();
//    }
//    class SmartHome
//    {
//        public string HomeName { get; set; }
//        List<Room> RoomList = new List<Room>();

//        public SmartHome(string homeName)
//        {
//            HomeName = homeName;
//        }

//        public void AddRoom(Room room) => RoomList.Add(room);
//    }

//    class Room
//    {
//        private int roomId { get; set; }
//        List<SmartDevice> SmartDevices = new List<SmartDevice>();
//        public Room(int roomId)
//        {
//            this.roomId = roomId;
//        }

//        public void AddDevice(SmartDevice device) => SmartDevices.Add(device);
//    }

//    public abstract class SmartDevice
//    {
//        public string DeviceId { get; set; }
//        public string DeviceName { get; set; }
//        public bool IsOn { get; protected set; }

//        public SmartDevice(string deviceId, string deviceName)
//        {
//            DeviceId = deviceId;
//            DeviceName = deviceName;
//            IsOn = false;
//        }

//        public virtual void TurnOn() => IsOn = true;
//        public virtual void TurnOff() => IsOn = false;
//        public abstract int GetPowerConsumption();

//    }

//    class SmartAc : SmartDevice, IConnectable
//    {
//        public SmartAc(string deviceId, string deviceName) : base(deviceId, deviceName) { }
//        public void WifiConnectivity()
//        {
//            Console.WriteLine("Ac have wifi connectivity");
//        }
//        public override int GetPowerConsumption()
//        {
//            return 15;
//        }
//    }

//    class SmartCamera : SmartDevice, IConnectable
//    {
//        public SmartCamera(string deviceId, string deviceName) : base(deviceId, deviceName) { }
//        public void WifiConnectivity()
//        {
//            Console.WriteLine("SmartCamera have wifi Connectivity");
//        }
//        public override int GetPowerConsumption()
//        {
//            return 10;
//        }
//    }

//    class SmartLight : SmartDevice
//    {
//        public SmartLight(string deviceId, string deviceName) : base(deviceId, deviceName)
//        {
//        }
//        public override int GetPowerConsumption()
//        {
//            return 1500;
//        }
//    }
//    class User
//    {
//        public string UserId { get; set; }
//        public string Name { get; set; }

//        public User(string userId, string name)
//        {
//            UserId = userId;
//            Name = name;
//        }

//        public void InspectDevice(SmartDevice device)
//        {
//            Console.WriteLine($"Inspecting device: {device.DeviceName}");
//        }
//    }
//    internal class SmartHomeAutomationSystem
//    {
//        static void Main(String[] args)
//        {
//            SmartAc ac = new SmartAc("D101", "Living Room AC");
//            SmartLight light = new SmartLight("D102", "Bedroom Light");
//            User user = new User("U1", "Sneha");
//            user.InspectDevice(ac);
//            user.InspectDevice(light);

//            ac.WifiConnectivity();
//        }
//    }
//}
