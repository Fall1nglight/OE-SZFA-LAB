using System.Text;
using Labor_01.Enums;

namespace Labor_01;

public class Cage
{
    // fields
    private readonly Animal?[] _animals;
    private int _numOfAnimals;

    // constructors
    public Cage(int size)
    {
        size = size > 10 ? 10 : size;
        _animals = new Animal[size];
    }

    // methods
    public bool Add(Animal animal)
    {
        if (_numOfAnimals == _animals.Length)
            return false;

        _animals[_numOfAnimals++] = animal;
        return true;
    }

    public void Delete(string name)
    {
        for (int i = 0; i < _numOfAnimals; i++)
        {
            // "dorka" , "botond" , "müzli"
            if (_animals[i]?.Name == name)
            {
                int idx = i;
                while (idx < _numOfAnimals - 1)
                    _animals[idx] = _animals[idx++];

                _animals[_numOfAnimals--] = null;
            }
        }
    }

    public int GetNumOfSpecies(Species species)
    {
        int count = 0;

        for (int i = 0; i < _numOfAnimals; i++)
        {
            if (_animals[i]?.Species == species)
                count++;
        }

        return count;
    }

    public bool ContainsAnimal(Species species, bool gender)
    {
        int idx = 0;

        while (
            idx < _numOfAnimals
            && !(_animals[idx]?.Species == species && _animals[idx]?.Gender == gender)
        )
            idx++;

        return idx < _numOfAnimals;
    }

    public Animal?[] GetAnimalsBySpecies(Species species)
    {
        int count = GetNumOfSpecies(species);
        Animal?[] animalsBySpecies = new Animal[count];

        int idx = 0;
        for (int i = 0; i < _numOfAnimals; i++)
        {
            if (_animals[i]?.Species == species)
                animalsBySpecies[idx++] = _animals[i];
        }

        return animalsBySpecies;
    }

    public double GetAvgAnimalWeightBySpecies(Species species)
    {
        Animal?[] animalsBySpecies = GetAnimalsBySpecies(species);
        int sum = 0;

        for (int i = 0; i < animalsBySpecies.Length; i++)
        {
            sum += animalsBySpecies[i]!.Weight;
        }

        double avg = (double)sum / animalsBySpecies.Length;
        return Math.Round(avg, 2);
    }

    public bool ContainsDifferentBreed()
    {
        bool result = false;

        foreach (var species in Enum.GetValues<Species>())
        {
            Animal?[] animals = GetAnimalsBySpecies(species);

            // ha csak 1 vagy kevesett db van az adott fajból tovább megyünk
            if (animals.Length <= 1)
                continue;

            bool gender = animals[0]!.Gender;

            for (var i = 1; i < animals.Length; i++)
            {
                if (animals[i]?.Gender != gender)
                {
                    result = true;
                    break;
                }
            }
        }

        return result;
    }

    public static int GetBiggestCage(Cage[] cages, Species species)
    {
        int maxIdx = 0;

        for (int i = 1; i < cages.Length; i++)
        {
            if (cages[i].GetNumOfSpecies(species) > cages[maxIdx].GetNumOfSpecies(species))
                maxIdx = i;
        }

        return maxIdx;
    }

    public static Cage Parse(string path)
    {
        string[] lines = File.ReadAllLines(path, Encoding.UTF8);

        Cage cage = new Cage(lines.Length);

        for (int i = 0; i < lines.Length; i++)
            cage.Add(Animal.Parse(lines[i]));

        return cage;
    }

    public static Cage[] ParseMultiple(string folder)
    {
        string[] files = Directory.GetFiles(@$"..\..\..\{folder}");
        Cage[] container = new Cage[files.Length];

        for (int i = 0; i < files.Length; i++)
            container[i] = Cage.Parse(files[i]);

        return container;
    }

    public void ToConsole()
    {
        Console.WriteLine("Állatok:");

        for (var i = 0; i < _numOfAnimals; i++)
            Console.WriteLine(_animals[i]);

        Console.WriteLine("=======");
    }
}
