namespace FizzBuzz
{
  public class FizzBuzz
  {
    public string For(int number) {
      if(number % 3 == 0)
      {
        return "Fizz";
      }
      else
      {
        return number.ToString();
      } 
    }
  }
}
