namespace Labor_02;

public class Rectangle : Shape
{
    // fields
    private int _height;
    private int _width;

    // constructors
    public Rectangle(int height, int width, bool isHoley, string color)
        : base(isHoley, color)
    {
        _height = height;
        _width = width;
    }

    public Rectangle(int height, int width, string color)
        : this(height, width, false, color) { }

    // methods
    public override double Perimeter() => 2 * (_height + _width);

    public override double Area() => _height * _width;

    public override string ToString()
    {
        string baseStr = base.ToString().Split("unique")[0];
        return $"{baseStr}rectangle";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Rectangle temp)
            return false;

        return _height == temp._height
            && _width == temp._width
            && Color == temp.Color
            && IsHoley == temp.IsHoley;
    }

    // properties
    public virtual int Height
    {
        get => _height;
        set => _height = value;
    }

    public virtual int Width
    {
        get => _width;
        set => _width = value;
    }
}
