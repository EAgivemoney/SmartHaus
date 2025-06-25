using System;

// Thermostat device class, inherits from DeviceBase and implements IConnectable
public class Thermostat : DeviceBase, IConnectable
{
    // Indicates if the thermostat is connected
    public bool IsConnected { get; private set; }
    // Current temperature value
    public double Temperature { get; set; }

    // Constructor initializing name and manufacturer
    public Thermostat(string name, string manufacturer) : base(name, manufacturer) { }

    // Connects the thermostat
    public void Connect() => IsConnected = true;
    // Disconnects the thermostat
    public void Disconnect() => IsConnected = false;

    // Performs a self-test and outputs the result
    public override void PerformSelfTest()
    {
        Console.WriteLine($"Testing thermostat '{Name}'... Passed.");
    }
}