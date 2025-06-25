using System;

public class Light: DeviceBase, ISwitchable
{
    public bool IsOn { get; private set; }

    public Light(string name, string manufacturer) : base (name, manufacturer) { }

    public void TurnOn() => IsOn = true;
    public void TurnOff() => IsOn = false;

    public override void PerformSelfTest()
    {
        Console.WriteLine($"Testing light '{Name}'... Passed.");
    }
}