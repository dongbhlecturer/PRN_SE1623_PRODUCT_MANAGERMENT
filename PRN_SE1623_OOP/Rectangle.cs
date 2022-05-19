public class Rectangle : IShape
{
    private double Height { get; set; }
    private double Width { get; set; }
    public double GetArea()
    {
        return Height * Width;
    }

    public double GetPerimetter()
    {
        return (Width + Height)*2;
    }
}