using System;

public class Thermostat : DeviceBase, IConnectable
{
    public bool IsConnected { get; private set; }
    public double Temperature { get; set; }

    public Thermostat(string name, string manufacturer) : base(name, manufacturer) { }

    public void Connect() => IsConnected = true;
    public void Disconnect() => IsConnected = false;

    public override void PerformSelfTest()
    {
        Console.WriteLine($"Testing thermostat '{Name}'... Passed.");
    }
}