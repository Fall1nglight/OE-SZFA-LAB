using Labor_03_base.Interfaces;

namespace Labor_03_base;

public class Lodgings : Flat, IRent
{
    // fields
    private int _bookedMonths;

    // constructors
    public Lodgings(double area, int roomsCount, double unitPrice)
        : base(area, roomsCount, 0, unitPrice)
    {
        _bookedMonths = 0;
    }

    // methods
    public override bool MoveIn(int newInhabitants)
    {
        // Moving in is only possible after the future inhabitants have booked.
        if (!IsBooked)
            return false;

        int tempInhabitants = InhabitantsCount + newInhabitants;

        // Maximum 8 inhabitants are allowed live in a single room together
        if (tempInhabitants > RoomsCount * 8)
            return false;

        // A single person requires at least 2m^2 area to be able to move in
        if (tempInhabitants * 2 > Area)
            return false;

        InhabitantsCount += newInhabitants;
        return true;
    }

    public int GetCost(int months)
    {
        if (months <= 0)
            return 0;

        return (int)Math.Ceiling((double)TotalValue() / 240 / InhabitantsCount * months);
    }

    public bool Book(int months)
    {
        if (IsBooked)
            return false;

        _bookedMonths = months;
        return true;
    }

    public override string ToString() => $"{base.ToString()}, booked for: {_bookedMonths} months";

    // properties
    public bool IsBooked => _bookedMonths == 0;

    protected int BookedMonths
    {
        get => _bookedMonths;
        set => _bookedMonths = value;
    }
}
