using System;

// Abstract base class for all devices
public abstract class DeviceBase
{
    // Name of the device
    public string Name { get; private set; }
    // Manufacturer of the device
    public string Manufacturer { get; private set; }

    // Constructor to initialize name and manufacturer
    protected DeviceBase(string name, string manufacturer)
    {
        Name = name;
        Manufacturer = manufacturer;
    }

    // Abstract method for performing a self-test
    public abstract void PerformSelfTest();
}