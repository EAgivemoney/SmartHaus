public interface ISwitchable
{
    void TurnOn(); // Turns the switchable object on

    void TurnOff(); // Turns the switchable object off

    bool IsOn { get; } // Gets a value indicating whether the object is on
}