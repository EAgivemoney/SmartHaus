using System;

public class DeviceController
{
    private readonly List<DeviceBase> _devices = new();

    public void AddDevice(DeviceBase device)
    {
        _devices.Add(device);
    }

    public void RunSelfTests()
    {
        foreach (var device in _devices)
        {
            device.PerformSelfTest();
        }
    }
}