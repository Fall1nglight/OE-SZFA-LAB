namespace Labor_02;

public class Square : Rectangle
{
    // fields

    // constructors
    public Square(int height, bool isHoley, string color)
        : base(height, height, isHoley, color) { }

    public Square(int height, string color)
        : base(height, height, color) { }

    // methods
    public override double Perimeter() => 4 * base.Height;

    public override double Area() => Math.Pow(base.Height, 2);

    public override string ToString()
    {
        var baseStr = base.ToString().Split("rectangle")[0];
        return $"{baseStr}square";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Square temp)
            return false;

        return Height == temp.Height
            && Width == temp.Width
            && Color == temp.Color
            && IsHoley == temp.IsHoley;
    }

    // properties
    public override int Height
    {
        get => base.Height;
        set => base.Height = base.Width = value;
    }

    public override int Width
    {
        get => base.Width;
        set => base.Width = base.Height = value;
    }
}
