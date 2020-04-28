using System;
using System.Collections.Generic;
using System.Threading;

namespace ViewModelTest.Model
{
    public class DeviceRepository
    {
        private static readonly int Id;
        
        public static List<Device> Devices = new List<Device>
        {
            new Device
            {
                Id = ++Id,
                Name = $"Device {Id}",
                BoolProperty1 = RandomBool(),
                BoolProperty2 = RandomBool(),
                IntProperty = 100,
                StringProperty = "Test text",
                DeviceFunction = new DeviceFunction1
                {
                    Id = Id,
                    Name = $"Device Function {Id}",
                    BoolProperty1 = RandomBool(),
                    BoolProperty2 = RandomBool(),
                    BoolProperty3 = RandomBool(),
                    BoolProperty4 = RandomBool(),
                    BoolProperty5 = RandomBool(),
                    StringProperty1 = $"Function {Id}-1",
                    StringProperty2 = $"Function {Id}-2",
                    StringProperty3 = $"Function {Id}-3",
                }
            },
            new Device
            {
                Id = ++Id,
                Name = $"Device {Id}",
                BoolProperty1 = RandomBool(),
                BoolProperty2 = RandomBool(),
                IntProperty = 100,
                StringProperty = "Test text",
                DeviceFunction = new DeviceFunction1
                {
                    Id = Id,
                    Name = $"Device Function {Id}",
                    BoolProperty1 = RandomBool(),
                    BoolProperty2 = RandomBool(),
                    BoolProperty3 = RandomBool(),
                    BoolProperty4 = RandomBool(),
                    BoolProperty5 = RandomBool(),
                    StringProperty1 = $"Function {Id}-1",
                    StringProperty2 = $"Function {Id}-2",
                    StringProperty3 = $"Function {Id}-3",
                }
            },
            new Device
            {
                Id = ++Id,
                Name = $"Device {Id}",
                BoolProperty1 = RandomBool(),
                BoolProperty2 = RandomBool(),
                IntProperty = 100,
                StringProperty = "Test text",
                DeviceFunction = new DeviceFunction1
                {
                    Id = Id,
                    Name = $"Device Function {Id}",
                    BoolProperty1 = RandomBool(),
                    BoolProperty2 = RandomBool(),
                    BoolProperty3 = RandomBool(),
                    BoolProperty4 = RandomBool(),
                    BoolProperty5 = RandomBool(),
                    StringProperty1 = $"Function {Id}-1",
                    StringProperty2 = $"Function {Id}-2",
                    StringProperty3 = $"Function {Id}-3",
                }
            },
            new Device
            {
                Id = ++Id,
                Name = $"Device {Id}",
                BoolProperty1 = RandomBool(),
                BoolProperty2 = RandomBool(),
                IntProperty = 100,
                StringProperty = "Test text",
                DeviceFunction = new DeviceFunction2
                {
                    Id = Id,
                    Name = $"Device Function {Id}",
                    BoolProperty1 = RandomBool(),
                    BoolProperty2 = RandomBool(),
                    BoolProperty3 = RandomBool(),
                    StringProperty1 = $"Function {Id}-1",
                    StringProperty2 = $"Function {Id}-2",
                }
            },
            new Device
            {
                Id = ++Id,
                Name = $"Device {Id}",
                BoolProperty1 = RandomBool(),
                BoolProperty2 = RandomBool(),
                IntProperty = 100,
                StringProperty = "Test text",
                DeviceFunction = new DeviceFunction2
                {
                    Id = Id,
                    Name = $"Device Function {Id}",
                    BoolProperty1 = RandomBool(),
                    BoolProperty2 = RandomBool(),
                    BoolProperty3 = RandomBool(),
                    StringProperty1 = $"Function {Id}-1",
                    StringProperty2 = $"Function {Id}-2",
                }
            },
        };

        public static bool RandomBool()
        {
            Thread.Sleep(10);
            return new Random().Next(2) == 1;
        }
    }
}