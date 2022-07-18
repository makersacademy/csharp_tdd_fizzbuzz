namespace FizzBuzz
{
  public class FizzBuzz
  {

    string soundOne;
    string soundTwo;

    // constructor is like initialize - it's called when you create a new instance

    public FizzBuzz() {
      this.soundOne = "Fizz";
      this.soundTwo = "Buzz";
    }

    public FizzBuzz(string soundOne, string soundTwo) {
      this.soundOne = soundOne;
      this.soundTwo = soundTwo;
    }
    public string For(int number) {
      if (number % 15 == 0)
      {
        return this.soundOne + this.soundTwo;
      }
      else if(number % 3 == 0)
      {
        return this.soundOne;
      }
      else if(number % 5 == 0)
      {
        return this.soundTwo;
      }
      else
      {
        return number.ToString();
      } 
    }
  }
}
