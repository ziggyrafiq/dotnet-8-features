// Example of optimised JIT compilation
namespace DotNet8FeaturesApp;

public static class MathOperations
{
    public static int Sum(int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    
    public static void DisplaySum(int[] numbers)
    {
        int sum = Sum(numbers);
        Console.WriteLine(sum switch
        {
            0 => "The array is empty.",
            > 0 => $"The sum is {sum}.",
            _ => "An error occurred."
        });
    }

}
