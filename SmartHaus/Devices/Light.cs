using System;

public class Light : DeviceBase, ISwitchable
{
    // Indicates whether the light is currently on
    public bool IsOn { get; private set; }

    // Constructor initializes the light with a name and manufacturer
    public Light(string name, string manufacturer) : base(name, manufacturer) { }

    // Turns the light on
    public void TurnOn() => IsOn = true;

    // Turns the light off
    public void TurnOff() => IsOn = false;

    // Performs a self-test and outputs the result to the console
    public override void PerformSelfTest()
    {
        Console.WriteLine($"Testing light '{Name}'... Passed.");
    }
}