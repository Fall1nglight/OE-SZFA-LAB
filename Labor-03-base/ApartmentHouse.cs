using Labor_03_base.Interfaces;

namespace Labor_03_base;

public class ApartmentHouse
{
    // fields
    private int _houseCount;
    private int _garageCount;
    private int _maxHouseCount;
    private int _maxGarageCount;

    // constructors
    public ApartmentHouse(int maxHouseCount, int maxGarageCount)
    {
        _maxHouseCount = maxHouseCount;
        _maxGarageCount = maxGarageCount;
        Container = new IRealEstate[maxHouseCount + maxGarageCount];
    }

    // methods
    public bool AddRealEstate(IRealEstate realEstate)
    {
        if (realEstate is Flat flat)
        {
            if (_maxHouseCount == _houseCount)
                return false;

            Container[_houseCount + _garageCount] = flat;
            _houseCount++;
        }

        if (realEstate is Garage garage)
        {
            if (_maxGarageCount == _garageCount)
                return false;

            Container[_houseCount + _garageCount] = garage;
            _garageCount++;
        }

        return false;
    }

    // properties
    public IRealEstate[] Container { get; private set; }

    public int InhabitantsCount
    {
        get
        {
            int sum = 0;
            int maxIdx = _houseCount + _garageCount;

            for (int i = 0; i < maxIdx; i++)
            {
                if (Container[i] is Flat flat)
                    sum += flat.InhabitantsCount;
            }

            return sum;
        }
    }
}
