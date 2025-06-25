using System;

public abstract class DeviceBase
{
    public string Name { get; private set; }
    public string Manufacturer { get; private set; }

    protected DeviceBase(string name, string manufacturer)
    {
        Name = name;
        Manufacturer = manufacturer;
    }

    public abstract void PerformSelfTest();
}