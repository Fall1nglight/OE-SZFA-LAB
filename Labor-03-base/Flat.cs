using Labor_03_base.Interfaces;

namespace Labor_03_base;

public abstract class Flat : IRealEstate
{
    // fields
    private double _area;
    private int _roomsCount;
    private int _inhabitantsCount;
    private double _unitPrice;

    // constructors
    protected Flat(double area, int roomsCount, int inhabitantsCount, double unitPrice)
    {
        _area = area;
        _roomsCount = roomsCount;
        _inhabitantsCount = inhabitantsCount;
        _unitPrice = unitPrice;
    }

    // methods
    public int TotalValue() => (int)Math.Ceiling(_area * _unitPrice);

    /// <summary>
    /// Attempts to move new inhabitants into the property.
    /// </summary>
    /// <param name="newInhabitants">The number of people attempting to move in.</param>
    /// <returns><c>true</c> if the move-in was successful; otherwise, <c>false</c>.</returns>
    public abstract bool MoveIn(int newInhabitants);

    /// <summary>
    /// Returns a string representation of the object's data members.
    /// </summary>
    /// <returns>A string containing the values of the object's properties.</returns>
    public override string ToString() =>
        $"area: {_area}, roomsCount: {_roomsCount}, inhabitantsCount: {_inhabitantsCount}, unitPrice: {_unitPrice}";

    // properties
    protected double Area
    {
        get => _area;
        set => _area = value;
    }

    protected int RoomsCount
    {
        get => _roomsCount;
        set => _roomsCount = value;
    }

    public int InhabitantsCount
    {
        get => _inhabitantsCount;
        protected set => _inhabitantsCount = value;
    }

    protected double UnitPrice
    {
        get => _unitPrice;
        set => _unitPrice = value;
    }
}
