using Labor_04_base;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Labor;

public class ArrayStatisticsTest
{
    // fields
    private ArrayStatistics _arrayStatistics;

    [SetUp]
    public void Setup()
    {
        // minden teszt előtt lefut
    }

    [TestCase(new[] { 1, 2, 7 }, 10, true)]
    [TestCase(new[] { -10, -20, -30 }, -60, true)]
    [TestCase(new[] { 15 }, 15, true)]
    [TestCase(new[] { 0 }, 0, true)]
    [TestCase(new[] { -125 }, -125, true)]
    [TestCase(new[] { 1, -7, 7, 4, 4, 4, -12 }, 1, true)]
    [TestCase(new[] { 1, 2, 7 }, 0, false)]
    [TestCase(new[] { -10, -20, -30 }, -55, false)]
    [TestCase(new[] { 0 }, 1, false)]
    public void TestTotal(int[] numbers, int sum, bool expected)
    {
        _arrayStatistics = new ArrayStatistics(numbers);
        Assert.That(_arrayStatistics.Total() == sum, Is.EqualTo(expected));
    }

    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, false)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, -1, false)]
    public void TestContains(int[] numbers, int toFind, bool expected)
    {
        _arrayStatistics = new ArrayStatistics(numbers);
        Assert.That(_arrayStatistics.Contains(toFind), Is.EqualTo(expected));
    }

    [TestCase(new[] { 0 }, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 5, 7, 8, 9 }, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 1 }, false)]
    [TestCase(new[] { 1, 9, 3, 3, 1, 13, 7, 8, 41, 10, 25, 14, 60, 14, 99, 101, 1 }, false)]
    public void TestSorted(int[] numbers, bool expected)
    {
        _arrayStatistics = new ArrayStatistics(numbers);
        Assert.That(_arrayStatistics.Sorted(), Is.EqualTo(expected));
    }

    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3, 3, true)]
    [TestCase(new[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 }, 3, 3, true)]
    [TestCase(new[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 }, -2, 0, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, 0, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9, -1, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 10, -1, true)]
    [TestCase(new[] { 1 }, 1, -1, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3, 0, false)]
    [TestCase(new[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 }, 5, 0, false)]
    [TestCase(new[] { 1 }, 1, 0, false)]
    [TestCase(new[] { 1 }, 11, -1, true)]
    public void TestFirstGreater(int[] numbers, int number, int index, bool expected)
    {
        _arrayStatistics = new ArrayStatistics(numbers);
        Assert.That(_arrayStatistics.FirstGreater(number) == index, Is.EqualTo(expected));
    }

    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, false)]
    [TestCase(new[] { -1, -2, -3, -4, -5, -6, -7, -8, -9 }, 4, true)]
    [TestCase(new[] { -1, -2, -3, -4, -5, -6, -7, -8, -9 }, 0, false)]
    [TestCase(new[] { 1 }, 0, true)]
    [TestCase(new[] { 1 }, 10, false)]
    public void CountEvens(int[] numbers, int numOfEvens, bool expected)
    {
        _arrayStatistics = new ArrayStatistics(numbers);
        Assert.That(_arrayStatistics.CountEvens() == numOfEvens, Is.EqualTo(expected));
    }

    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 8, true)]
    [TestCase(new[] { 10, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, true)]
    [TestCase(new[] { -1, -2, -3, -4, -5, -6, -7, -8, -9 }, 0, true)]
    [TestCase(new[] { 1 }, 0, true)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, false)]
    [TestCase(new[] { 10, 2, 3, 4, 5, 6, 7, 8, 9 }, 10, false)]
    [TestCase(new[] { -1, -2, -3, -4, -5, -6, -7, -8, -9 }, -1, false)]
    [TestCase(new[] { 1 }, 1, false)]
    public void TestMaxIndex(int[] numbers, int index, bool expected)
    {
        _arrayStatistics = new ArrayStatistics(numbers);
        Assert.That(_arrayStatistics.MaxIndex() == index, Is.EqualTo(expected));
    }

    [TestCase(new[] { 9, 2, 1 }, new[] { 1, 2, 9 })]
    [TestCase(
        new[] { 1, 9, 3, 3, 1, 13, 7, 8, 41, 10, 25, 14, 60, 14, 99, 101, 1 },
        new[] { 1, 1, 1, 3, 3, 7, 8, 9, 10, 13, 14, 14, 25, 41, 60, 99, 101 }
    )]
    [TestCase(new[] { 1 }, new[] { 1 })]
    public void TestSort(int[] numbers, int[] orderedNumbers)
    {
        _arrayStatistics = new ArrayStatistics(numbers);
        _arrayStatistics.Sort();
        Assert.That(_arrayStatistics.Numbers, Is.EqualTo(orderedNumbers));
    }
}
