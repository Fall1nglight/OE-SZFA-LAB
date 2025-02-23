using Labor_01.Enums;

namespace Labor_01;

internal class Program
{
    public static void Main(string[] args)
    {
        // create cages
        Cage cage1 = new Cage(5);
        Cage cage2 = new Cage(3);
        Cage cage3 = new Cage(10);
        Cage cage4 = new Cage(7);

        FillCages();

        Cage[] container = { cage1, cage2, cage3, cage4 };

        // 1.
        Console.WriteLine("1. feladat");
        Console.WriteLine($"\tKutyák száma: {cage1.GetNumOfSpecies(Species.Dog)}");

        // 2.
        Console.WriteLine("2. feladat");
        Console.WriteLine($"\tVan-e hím kutya? {cage1.ContainsAnimal(Species.Dog, true)}");

        // 3.
        Console.WriteLine("3. feladat");
        Console.WriteLine("\tKutyák");
        Animal?[] dogs = cage1.GetAnimalsBySpecies(Species.Dog);

        foreach (var animal in dogs)
            Console.WriteLine($"\t\t{animal?.Name}");

        // 4.
        Console.WriteLine("4. feladat");
        Console.WriteLine(
            $"\tKutyák átlagos tömege: {cage1.GetAvgAnimalWeightBySpecies(Species.Dog)}"
        );

        // 5.
        Console.WriteLine("5. feladat");
        Console.WriteLine(
            $"\tVan-e azonos fajú, de ellenkező nemű állat? {cage1.ContainsDifferentBreed()}"
        );

        // 6.
        Console.WriteLine("6. feladat");
        Console.WriteLine(
            $"\tA legtöbb kutya a(z) {Cage.GetBiggestCage(container, Species.Dog) + 1}. ketrecben található."
        );

        void FillCages()
        {
            Animal animal1 = new Animal("Dorka", false, 40, Species.Dog);
            Animal animal2 = new Animal("Botond", true, 30, Species.Dog);
            Animal animal3 = new Animal("Müzli", true, 10, Species.Dog);
            Animal animal4 = new Animal("Lili", false, 7, Species.Pandra);
            Animal animal5 = new Animal("Mimi", true, 10, Species.Pandra);
            Animal animal6 = new Animal("Mufirc", true, 5, Species.Pandra);
            Animal animal7 = new Animal("Pisze", false, 3, Species.Rabbit);
            Animal animal8 = new Animal("Füles", true, 2, Species.Rabbit);
            Animal animal9 = new Animal("Méri", true, 1, Species.Rabbit);
            Animal animal10 = new Animal("Lofras", true, 12, Species.Dog);

            cage1.Add(animal1);
            cage1.Add(animal2);
            cage1.Add(animal3);
            cage1.Add(animal4);
            cage1.Add(animal5);
            cage1.Add(animal10);

            cage2.Add(animal4);
            cage2.Add(animal5);
            cage2.Add(animal6);

            cage3.Add(animal5);
            cage3.Add(animal6);
            cage3.Add(animal7);
            cage3.Add(animal8);
            cage3.Add(animal9);

            cage4.Add(animal9);
            cage4.Add(animal8);
            cage4.Add(animal7);
        }
    }
}
