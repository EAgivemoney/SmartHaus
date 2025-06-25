using System;

class Program
{
    static void Main()
    {
        var light = new Light("Living Room Light", "Philips");
        var thermostat = new Thermostat("Nest Thermostat", "Google");
        var plug = new SmartPlug("Coffee Maker Plug", "TP-Link");

        var livingRoom = new Room("Living Room");
        livingRoom.AddDevice(light);
        livingRoom.AddDevice(thermostat);

        var controller = new DeviceController();
        controller.AddDevice(light);
        controller.AddDevice(thermostat);
        controller.AddDevice(plug);

        livingRoom.ShowDevices();
        controller.RunSelfTests();

        light.TurnOn();
        plug.Connect();
        plug.TurnOn();

        Console.WriteLine($"Light is on: {light.IsOn}");
        Console.WriteLine($"Plug connected: {plug.IsConnected}, Plug on: {plug.IsOn}");
    }
}