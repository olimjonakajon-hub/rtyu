class Thermostat : IDevice
{
    public double Temperature { get; set; } = 20;

    public void TurnOn()
    {
    }

    public void TurnOff()
    {
    }

    public void SetTemperature(double temperature)
    {
        Temperature = temperature;
        Console.WriteLine( Temperature);
    }
}
