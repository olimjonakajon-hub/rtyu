class Lamp : IDevice
{
    public string Color { get; set; } 

    public void TurnOn()
    {
        Console.WriteLine("charog");
    }

    public void TurnOff()
    {
        Console.WriteLine("dfghjk");
    }

    public void ChangeColor(string color)
    {
        Color = color;
        Console.WriteLine(Color);
    }
}
