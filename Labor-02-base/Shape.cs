namespace Labor_02;

public abstract class Shape
{
    // fields
    private bool _isHoley;
    private string _color;

    // constructors
    protected Shape(bool isHoley, string color)
    {
        _isHoley = isHoley;
        _color = color;
    }

    protected Shape(string color)
        : this(false, color) { }

    // methods
    public void MakeHoley() => _isHoley = true;

    public abstract double Perimeter();

    public abstract double Area();

    public override string ToString() =>
        $"color: {_color} - {(_isHoley ? "holey" : "not holey")} - perimeter: {Perimeter()} - area: {Area()} - shape: unique";

    public override bool Equals(object? obj)
    {
        if (obj is not Shape temp)
            return false;

        return Color == temp.Color && IsHoley == temp.IsHoley;
    }

    // properties
    public string Color
    {
        get => _color;
        set => _color = value ?? throw new ArgumentNullException(nameof(value));
    }

    protected bool IsHoley => _isHoley;
}
