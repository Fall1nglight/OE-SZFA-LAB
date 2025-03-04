namespace Labor_03_base;

public class FamilyApartment : Flat
{
    // fields
    private int _childrenCount;

    // constructors
    public FamilyApartment(double area, int roomsCount, double unitPrice)
        : base(area, roomsCount, 0, unitPrice)
    {
        _childrenCount = 0;
    }

    // methods
    public override bool MoveIn(int newInhabitants)
    {
        double correctedInhabitantsCount =
            InhabitantsCount - _childrenCount + _childrenCount * 0.5 + newInhabitants;

        // Max 2 people are allowed to live tohgether in a single room
        if (correctedInhabitantsCount > RoomsCount * 2)
            return false;

        // * Checks if the new amount of inhabitants could fit in the area of the apartment
        if (correctedInhabitantsCount * 10 > Area)
            return false;

        InhabitantsCount += newInhabitants;
        return true;
    }

    /// <summary>
    /// Checks if there are at least two adult inhabitants in the apartment.
    /// If so, increases both the total number of inhabitants and the number of children by one.
    /// </summary>
    /// <returns><c>true</c> if a child is born and the counts are updated; otherwise, <c>false</c>.</returns>
    public bool ChildIsBorn()
    {
        if (InhabitantsCount - _childrenCount < 2)
            return false;

        InhabitantsCount++;
        _childrenCount++;
        return true;
    }

    public override string ToString() => $"{base.ToString()}, number of children: {_childrenCount}";

    // properties
    protected int ChildrenCount => _childrenCount;
}
