namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void For_NumbersNotDivisibleByThreeOrFive_ReturnTheNumber()
    {
        // Arrange - creating objects
        FizzBuzz fizzBuzz = new FizzBuzz();
        // Act - call the method under test
        int actual = fizzBuzz.For(1);
        int expected = 1;
        // Assert - assert that the method did what it should
        Assert.AreEqual(expected, actual);
    }
}