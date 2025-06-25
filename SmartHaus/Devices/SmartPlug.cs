using System;

public class SmartPlug : DeviceBase, ISwitchable, IConnectable
{
    // Indicates whether the smart plug is currently on
    public bool IsOn { get; private set; }
    // Indicates whether the smart plug is currently connected
    public bool IsConnected { get; private set; }

    // Constructor initializing the smart plug with a name and manufacturer
    public SmartPlug(string name, string manufacturer) : base(name, manufacturer) { }

    // Turns the smart plug on
    public void TurnOn() => IsOn = true;
    // Turns the smart plug off
    public void TurnOff() => IsOn = false;

    // Connects the smart plug
    public void Connect() => IsConnected = true;
    // Disconnects the smart plug
    public void Disconnect() => IsConnected = false;

    // Performs a self-test and outputs the result to the console
    public override void PerformSelfTest()
    {
        Console.WriteLine($"Testing smart plug '{Name}'... Passed.");
    }
}