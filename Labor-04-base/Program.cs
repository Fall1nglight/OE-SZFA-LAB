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

        // Console.ReadLine();
        Console.Clear();
        #endregion

        #region 2. exerecise
        Console.WriteLine("2. exercise");

        ArrayStatistics arrayStatistics = new ArrayStatistics();
        arrayStatistics.RunExamples();

        Console.Clear();
        // Console.ReadLine();
        #endregion

        #region 3. exercise
        Console.WriteLine("3. exercise");
        Stack stack = new Stack(5);

        Console.WriteLine(stack.GetAllItems());

        FillStack();

        Console.WriteLine(stack.GetAllItems());
        Console.WriteLine($"Is the stack empty? {(stack.Empty() ? "Yes" : "No")}");
        Console.WriteLine($"Is the stack full? {(stack.Full() ? "Yes" : "No")}");

        PopFromStack(3);

        Console.WriteLine(stack.GetAllItems());

        // helper methods
        void FillStack()
        {
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            stack.Push('d');
            stack.Push('q');
        }

        void PopFromStack(int numOfItems)
        {
            for (int i = 0; i < numOfItems; i++)
            {
                bool result = stack.Pop(out char item);

                Console.WriteLine(
                    result
                        ? $"Latest item popped: {item}"
                        : "Item could not be popped, because the stack is empty."
                );
            }
        }

        #endregion
    }
}
