namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1,1)]
    [TestCase(2,2)]
    [TestCase(4,4)]
    [TestCase(7,7)]
    public void For_NumbersNotDivisibleByThreeOrFive_ReturnTheNumber(int input, int expected)
    {
        // Arrange - creating objects
        FizzBuzz fizzBuzz = new FizzBuzz();
        // Act - call the method under test
        int actual = fizzBuzz.For(input);
        // Assert - assert that the method did what it should
        Assert.AreEqual(expected, actual);
    }
}