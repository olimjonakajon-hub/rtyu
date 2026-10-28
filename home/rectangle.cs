public class Rectangle : Shape
{
    private double Length;
    private double Width;

    public Rectangle(string color, double l,double w) : base(color)
    {
        Length = l;
        Width = w;
        
    }
}