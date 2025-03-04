using Labor_04_base.Interfaces;

namespace Labor_04_base;

public class PrimeToolManager
{
    // fields
    private IPrimeTool _primeTool;

    // constructors
    public PrimeToolManager(IPrimeTool primeTool)
    {
        _primeTool = primeTool;
    }

    // methods
    public string IsPrimeToText() => _primeTool.IsPrime() ? "It's a Prime." : "It's not a Prime";

    // properties
}
