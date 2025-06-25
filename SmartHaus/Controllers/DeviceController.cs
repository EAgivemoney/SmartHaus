using System;

public class DeviceController
{
    // List to store all registered devices
    private readonly List<DeviceBase> _devices = new();

    // Adds a device to the controller
    public void AddDevice(DeviceBase device)
    {
        _devices.Add(device);
    }

    // Runs self-tests on all registered devices
    public void RunSelfTests()
    {
        foreach (var device in _devices)
        {
            device.PerformSelfTest();
        }
    }
}