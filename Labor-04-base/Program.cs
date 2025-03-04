namespace Labor_04_base;

internal class Program
{
    public static void Main(string[] args)
    {
        #region 1. exercise
        Console.WriteLine("1. exercise");

        int numToTest1 = 7;
        int numToTest2 = 16;

        PrimeTool pt1 = new PrimeTool(7);
        PrimeTool pt2 = new PrimeTool(16);

        Console.WriteLine($"Is {numToTest1} a prime? {(pt1.IsPrime() ? "Yes" : "No")}");
        Console.WriteLine($"Is {numToTest2} a prime? {(pt2.IsPrime() ? "Yes" : "No")}");

        Console.ReadLine();
        Console.Clear();
        #endregion

        #region 2. exerecise
        Console.WriteLine("2. exercise");

        ArrayStatistics arrayStatistics = new ArrayStatistics();
        arrayStatistics.RunExamples();
        #endregion
    }
}
