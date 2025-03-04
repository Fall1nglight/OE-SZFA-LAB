using Labor_04_base;
using Labor_04_base.Interfaces;
using Moq;

namespace Labor;

public class PrimeToolTest
{
    private PrimeTool _primeTool;

    [SetUp]
    public void Setup()
    {
        // minden teszt előtt lefut
    }

    [TestCase(2, true)]
    [TestCase(3, true)]
    [TestCase(4, false)]
    [TestCase(15, false)]
    public void IsPrime(int toTest, bool expected)
    {
        // Assert.Pass(), Assert.Fail()
        _primeTool = new PrimeTool(toTest);
        Assert.That(_primeTool.IsPrime(), Is.EqualTo(expected));
    }

    // Mock
    [Test]
    public void MockTest()
    {
        // Mock példány
        Mock<IPrimeTool> mock = new Mock<IPrimeTool>();

        // Beállítjuk, hogy működjön
        mock.Setup(x => x.IsPrime()).Returns(true);

        // PTM létrehozása -> mock.object-el
        PrimeToolManager ptm = new PrimeToolManager(mock.Object);

        // tesztelés
        Assert.That(ptm.IsPrimeToText(), Is.EqualTo("It's a Prime."));
    }
}
