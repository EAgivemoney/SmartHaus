using System;

public class Room
{
    public string Name { get; } // Name of the room
    public List<DeviceBase> Devices { get; } = new(); // List of devices in the room

    public Room(string name)
    {
        Name = name; // Set the room name
    }

    public void AddDevice(DeviceBase device)
    {
        Devices.Add(device); // Add a device to the room
    }

    public void ShowDevices()
    {
        Console.WriteLine($"Devices in room {Name}:"); // Display room name
        foreach (var device in Devices)
        {
            Console.WriteLine($" - {device.Name}"); // Display each device name
        }
    }
}