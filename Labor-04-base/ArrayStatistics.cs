using System.Text;

namespace Labor_04_base;

public class ArrayStatistics
{
    // fields
    private readonly int[] _exampleNumbers =
    {
        1,
        9,
        3,
        3,
        1,
        13,
        7,
        8,
        41,
        10,
        25,
        14,
        60,
        14,
        99,
        101,
        1,
    };
    private int[] _numbers;

    // constructors
    public ArrayStatistics()
    {
        _numbers = Array.Empty<int>();
    }

    public ArrayStatistics(int[] numbers)
    {
        _numbers = numbers;
    }

    // methods
    /// <summary>
    /// Calculates and returns the sum of all elements in the array.
    /// </summary>
    /// <returns>The total sum of elements in the array.</returns>
    public int Total()
    {
        int sum = 0;

        for (int i = 0; i < _numbers.Length; i++)
            sum += _numbers[i];

        return sum;
    }

    /// <summary>
    /// Determines whether the specified number exists in the array.
    /// </summary>
    /// <param name="number">The number to search for.</param>
    /// <returns>True if the number is found in the array, otherwise false.</returns>
    public bool Contains(int number)
    {
        // indexer
        int i = 0;

        // iterate through the array until the number is found or the end is reached
        while (i < _numbers.Length && _numbers[i] != number)
            i++;

        // return true if the number was found (index is within bounds)
        return i < _numbers.Length;
    }

    /// <summary>
    /// Checks whether the elements of the array are sorted in ascending order.
    /// </summary>
    /// <returns>True if the array is sorted in ascending order, otherwise false.</returns>
    public bool Sorted()
    {
        // indexer
        int i = 0;

        // iterate through the array while elements are in ascending order
        while (i < _numbers.Length - 1 && _numbers[i] <= _numbers[i + 1])
            i++;

        // if index reaches the last element, the array is sorted
        return i == _numbers.Length - 1;
    }

    /// <summary>
    /// Finds the index of the first element in the array that is greater than the given value.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The index of the first element greater than the specified value, or -1 if no such element exists.</returns>
    public int FirstGreater(int value)
    {
        // indexer
        int i = 0;

        // iterate thorugh the array while elements are less or equal to the given parameter
        while (i < _numbers.Length && _numbers[i] <= value)
            i++;

        // return the index of the first greater element if exists otherwise -1
        return i < _numbers.Length ? i : -1;
    }

    /// <summary>
    /// Counts the number of even numbers in the array.
    /// </summary>
    /// <returns>The count of even numbers in the array.</returns>
    public int CountEvens()
    {
        int count = 0;

        for (int i = 0; i < _numbers.Length; i++)
        {
            if (_numbers[i] % 2 == 0)
                count++;
        }

        return count;
    }

    /// <summary>
    /// Finds and returns the index of the largest element in the array.
    /// </summary>
    /// <returns>The index of the maximum element in the array.</returns>
    public int MaxIndex()
    {
        int maxIdx = 0;

        for (int i = 1; i < _numbers.Length; i++)
        {
            if (_numbers[i] > _numbers[maxIdx])
                maxIdx = i;
        }

        return maxIdx;
    }

    /// <summary>
    /// Sorts the array in ascending order using the Selection Sort algorithm.
    /// This algorithm iterates through the array, selecting the smallest
    /// element in the unsorted portion and swapping it with the first
    /// unsorted element.
    /// </summary>
    public void Sort()
    {
        // iterate through the array, treating each element as the starting point
        for (int i = 0; i < _numbers.Length - 1; i++)
        {
            // assume the current element is the smallest
            int minIdx = i;

            // find the smallest element in the unsorted portion of the array
            for (int j = i + 1; j < _numbers.Length; j++)
            {
                if (_numbers[minIdx] > _numbers[j])
                    minIdx = j;
            }

            // swap the found element with the current element
            (_numbers[i], _numbers[minIdx]) = (_numbers[minIdx], _numbers[i]);
        }
    }

    /// <summary>
    /// Runs a series of example operations on the array and prints the results.
    /// It temporarily replaces the current array with example numbers, performs
    /// various operations (e.g., sorting, searching, counting), and restores
    /// the original array at the end.
    /// </summary>
    public void RunExamples()
    {
        var oldNumbers = _numbers.ToArray();
        _numbers = _exampleNumbers;

        Console.WriteLine(GetAllElements());
        Console.WriteLine($"Sum of the array: {Total()}");
        Console.WriteLine($"Does the array contain number 3? {(Contains(3) ? "Yes" : "No")}");
        Console.WriteLine($"Is the array sorted in ascending order? {(Sorted() ? "Yes" : "No")}");
        Sort();
        Console.WriteLine(GetAllElements());
        Console.WriteLine($"Is the array sorted in ascending order? {(Sorted() ? "Yes" : "No")}");
        Console.WriteLine($"Index of the first greater number than 100: {FirstGreater(100)}");
        Console.WriteLine($"Index of the first greater number than 300: {FirstGreater(300)}");
        Console.WriteLine($"Number of evens: {CountEvens()}");
        Console.WriteLine($"Index of the largest value element: {MaxIndex()}");

        _numbers = oldNumbers.ToArray();
    }

    /// <summary>
    /// Returns a string representation of all elements in the array.
    /// The elements are displayed in a comma-separated format.
    /// </summary>
    /// <returns>A formatted string containing all array elements.</returns>
    private string GetAllElements()
    {
        StringBuilder sb = new StringBuilder("Elements of the array: ");

        for (int i = 0; i < _numbers.Length; i++)
            sb.Append($"{_numbers[i]}, ");

        return sb.ToString();
    }

    // properties
    public int[] Numbers => _numbers;
}
