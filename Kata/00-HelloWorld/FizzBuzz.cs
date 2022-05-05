using System;
using System.Globalization;

namespace Kata.FizzBuzz;

public class FizzBuzz
{
    // public static bool IsNumber(string printNumber) => string.IsNullOrEmpty(printNumber);
    // public static bool IsBuzz(int i) => i % 5 == 0;
    // public static bool IsFizz(int i) => i % 3 == 0;

    // public static string GetFizzBuzz(int number)
    // {
    //     string result = null;
    //     if(IsFizz(number) && IsBuzz(number)) result = "Fizzbuzz";
    //     return result;
    // }

    // public static string GetFizz(int number)
    // {
    //     string result = null;
    //     if(IsFizz(number)) result = "Fizz";
    //     return result;
    // }

    // public static string GetBuzz(int number)
    // {
    //     string result = null;
    //     if(IsBuzz(number)) result = "Buzz";
    //     return result;
    // }

    // public static string printFizzBuzz()
    // {
    //     var resultFizzBuzz = string.Empty;
    //     resultFizzBuzz = GetNumbers(resultFizzBuzz);
    //     return resultFizzBuzz;
    // }
    // public static void ThrowArgumentExceptionWhenNumberNotInRule(int number)
    // {
    //     if (number > 100 || number < 1)
    //         throw new ArgumentException(
    //             string.Format("Enter number should be between 1 to 100.",number));
    // }

    // public static string GetNumbers(string resultFizzBuzz)
    //     {
    //         for (var i = 1; i <= 100; i++)
    //         {
    //             var printNumber = string.Empty;
    //             if (IsFizz(i)) printNumber += "Fizz";
    //             if (IsBuzz(i)) printNumber += "Buzz";
    //             if (IsNumber(printNumber))
    //                 printNumber = i.ToString(CultureInfo.InvariantCulture);
    //             resultFizzBuzz += " " + printNumber;
    //         }
    //         return resultFizzBuzz.Trim();
    //     }

    // public static string PrintFizzBuzz(int number)
    //     {
    //         ThrowArgumentExceptionWhenNumberNotInRule(number);

    //         var result = GetFizzBuzz(number);
    //         if (string.IsNullOrEmpty(result))
    //         {
    //             result = GetFizz(number);
    //         }

    //         if (string.IsNullOrEmpty(result))
    //         {
    //             result = GetBuzz(number);
    //         }

    //         return string.IsNullOrEmpty(result) ? number.ToString(CultureInfo.InvariantCulture) : result;
    //     }
    public string SayFizzBuzz(int number)
    {
        
        if(number > 100)
            return "Enter number should be between 1 to 100";
        else if(number <= 0)
            return "Enter number should be between 1 to 100";
        else if(number % 3 == 0 && number % 5 ==0)
            return "FizzBuzz";
        else if(number % 3 == 0)
            return "Fizz";
        else if(number % 5 == 0)
            return "Buzz";
        else
            return number.ToString();
    }

    
}

