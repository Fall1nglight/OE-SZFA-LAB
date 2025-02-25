namespace Labor_02;

public class Circle : Shape
{
    // fields
    private int _radius;

    // constructors
    public Circle(int radius, bool isHoley, string color)
        : base(isHoley, color)
    {
        _radius = radius;
    }

    public Circle(int radius, string color)
        : this(radius, false, color) { }

    // methods
    public override double Perimeter() => Math.Round(2 * _radius * Math.PI, 2);

    public override double Area() => Math.Round(Math.Pow(_radius, 2) * Math.PI, 2);

    public override string ToString()
    {
        string baseStr = base.ToString().Split("unique")[0];
        return $"{baseStr}circle";
    }

    // properties
    public int Radius
    {
        get => _radius;
        set => _radius = value;
    }
}
