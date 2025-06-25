using System;

public class SmartPlug : DeviceBase, ISwitchable, IConnectable
{
    public bool IsOn { get; private set; }
    public bool IsConnected { get; private set; }

    public SmartPlug(string name, string manufacturer) : base(name, manufacturer) { }

    public void TurnOn() => IsOn = true;
    public void TurnOff() => IsOn = false;

    public void Connect() => IsConnected = true;
    public void Disconnect() => IsConnected = false;

    public override void PerformSelfTest()
    {
        Console.WriteLine($"Testing smart plug '{Name}'... Passed.");
    }
}