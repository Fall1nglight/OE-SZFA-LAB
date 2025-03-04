using Labor_03_base.Interfaces;

namespace Labor_03_base;

public class Garage : IRealEstate, IRent
{
    // fields´
    private double _area;
    private double _unitPrice;
    private bool _isHeated;
    private int _months;
    private bool _isOccupied;

    // constructors
    public Garage(double area, double unitPrice, bool isHeated, int months, bool isOccupied)
    {
        _area = area;
        _unitPrice = unitPrice;
        _isHeated = isHeated;
        _months = months;
        _isOccupied = isOccupied;
    }

    // methods
    public int TotalValue() => (int)Math.Ceiling(_area * _unitPrice);

    public int GetCost(int months)
    {
        double baseCost = (double)TotalValue() / 120 * (_isHeated ? 1.5 : 1);
        return (int)Math.Ceiling(baseCost * months);
    }

    public bool Book(int months)
    {
        if (IsBooked)
            return false;

        _months = months;
        return true;
    }

    public void UpdateOccupied() => _isOccupied = !_isOccupied;

    public override string ToString() => "";

    // properties
    public bool IsBooked => _months > 0 && !_isOccupied;
}
