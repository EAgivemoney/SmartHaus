using System;

class Program
{
    static void Main()
    {
        // Create a new light device
        var light = new Light("Living Room Light", "Philips");
        // Create a new thermostat device
        var thermostat = new Thermostat("Nest Thermostat", "Google");
        // Create a new smart plug device
        var plug = new SmartPlug("Coffee Maker Plug", "TP-Link");

        // Create a new room and add devices to it
        var livingRoom = new Room("Living Room");
        livingRoom.AddDevice(light);
        livingRoom.AddDevice(thermostat);

        // Create a device controller and add all devices
        var controller = new DeviceController();
        controller.AddDevice(light);
        controller.AddDevice(thermostat);
        controller.AddDevice(plug);

        // Show devices in the living room
        livingRoom.ShowDevices();
        // Run self-tests on all devices
        controller.RunSelfTests();

        // Turn on the light
        light.TurnOn();
        // Connect and turn on the smart plug
        plug.Connect();
        plug.TurnOn();

        // Output the status of the light
        Console.WriteLine($"Light is on: {light.IsOn}");
        // Output the status of the plug
        Console.WriteLine($"Plug connected: {plug.IsConnected}, Plug on: {plug.IsOn}");
    }
}