using System;

public class Room
{
    public string Name { get; }
    public List<DeviceBase> Devices { get; } = new();

    public Room(string name)
    {
        Name = name;
    }

    public void AddDevice(DeviceBase device)
    {
        Devices.Add(device);
    }

    public void ShowDevices()
    {
        Console.WriteLine($"Devices in room {Name}:");
        foreach (var device in Devices)
        {
            Console.WriteLine($" - {device.Name}");
        }
    }
}