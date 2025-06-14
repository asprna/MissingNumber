using MissingNumber.Interfaces;

namespace MissingNumber.App;

public sealed class MissingNumberApp(IMissingNumberFinder finder)
{
    public void Run()
    {
        Console.WriteLine("Enter comma-separated numbers (e.g., 3,0,1):");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be null, empty, or whitespace.");
            return;
        }

        try
        {
            var numbers = ParseInput(input);
            var missing = finder.FindMissingNumber(numbers);
            Console.WriteLine($"Missing number is: {missing}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private int[] ParseInput(string input)
    {
        return input
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(s => int.Parse(s.Trim()))
            .ToArray();
    }
}