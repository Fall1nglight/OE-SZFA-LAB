using Labor_04_base.Interfaces;

namespace Labor_04_base;

public class PrimeTool : IPrimeTool
{
    // fields
    private int _num;

    // constructors
    public PrimeTool(int num)
    {
        _num = num;
    }

    // methods
    public bool IsPrime()
    {
        int i = 2;

        while (i <= Math.Sqrt(_num) && _num % i != 0)
            i++;

        return i > Math.Sqrt(_num);
    }

    // properties
    public int Num => _num;
}
