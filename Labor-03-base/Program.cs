namespace Labor_03_base;

internal class Program
{
    public static void Main(string[] args)
    {
        MemeCat memeCat1 = new MemeCat("NyanCat", 10);
        MemeCat memeCat2 = new MemeCat("GrumpyCat", 4);
        MemeCat memeCat3 = new MemeCat("Smudge", 5);

        MemeCat[] cats = { memeCat1, memeCat2, memeCat3 };

        Array.Sort(cats);
        ;
    }
}
