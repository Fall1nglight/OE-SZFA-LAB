using Labor_01.Enums;

namespace Labor_01;

public class Animal
{
    // fields
    private string _name;
    private bool _gender;
    private int _weight;
    private Species _species;

    // constructors
    public Animal(string name, bool gender, int weight, Species species)
    {
        _name = name;
        _gender = gender;
        _weight = weight;
        _species = species;
    }

    // methods
    public override string ToString() =>
        $"{_name} - {(_gender ? "hím" : "nőstény")} - {_weight} kg - {_species}";

    public static Animal Parse(string line)
    {
        string[] arr = line.Split(",");
        string name = arr[0];
        bool gender = Boolean.Parse(arr[1]);
        int weight = int.Parse(arr[2]);
        Species species = Enum.Parse<Species>(arr[3]);
        return new Animal(name, gender, weight, species);
    }

    // properties
    public string Name => _name;

    public bool Gender => _gender;

    public int Weight => _weight;

    public Species Species => _species;
}
