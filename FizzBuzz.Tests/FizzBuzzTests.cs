namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1,"1")]
    [TestCase(2,"2")]
    [TestCase(4,"4")]
    [TestCase(7,"7")]
    public void For_NumbersNotDivisibleByThreeOrFive_ReturnTheNumber(int input, string expected)
    {
        // Arrange - creating objects
        FizzBuzz fizzBuzz = new FizzBuzz();
        // Act - call the method under test
        string actual = fizzBuzz.For(input);
        // Assert - assert that the method did what it should
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase(3, "Fizz")]
    [TestCase(6, "Fizz")]
    [TestCase(9, "Fizz")]
    public void For_NumbersDivisibleByThree_ReturnFizz(int input, string expected) {
        FizzBuzz fizzBuzz = new FizzBuzz();
        string actual = fizzBuzz.For(input);
        Assert.AreEqual(expected, actual);
    }

     [Test]
    public void For_NumbersDivisibleByFive_ReturnBuzz() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        string actual = fizzBuzz.For(5);
        string expected = "Buzz";
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void For_NumbersDivisibleByThreeAndFive_ReturnFizzBuzz() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        string actual = fizzBuzz.For(15);
        string expected = "FizzBuzz";
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase(15, "QuackWoof")]
    [TestCase(3, "Quack")]
    [TestCase(5, "Woof")]
    public void For_UsingCustomSounds_ReturnsCustomSounds(int input, string expected) {
        FizzBuzz fizzBuzz = new FizzBuzz("Quack", "Woof");
        string actual = fizzBuzz.For(input);
        Assert.AreEqual(expected, actual);
    }
}