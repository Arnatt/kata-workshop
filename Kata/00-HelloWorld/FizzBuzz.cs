namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string SayFizzBuzz(int number)
    {
        if(number == 1)
            return "1";
        if(number == 2)
            return "2";
        if(number % 3 == 0)
            return "Fizz";
        if(number % 5 == 0)
            return "Buzz";
            
        return null;
    }
}

