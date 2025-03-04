namespace Labor_03_base;

public class MemeCat : IComparable
{
    // fields
    private string _name;
    private int _age;

    // constructors
    public MemeCat(string name, int age)
    {
        _name = name;
        _age = age;
    }

    // methods
    public int CompareTo(object? obj)
    {
        //
        if (obj is not MemeCat temp)
            return 0;

        // return string.Compare(_name, temp._name, StringComparison.Ordinal);
        return _age.CompareTo(temp._age);
    }

    // properties
    public string Name => _name;
    public int Age => _age;
}
