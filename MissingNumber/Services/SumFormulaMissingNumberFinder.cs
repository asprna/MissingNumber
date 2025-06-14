using MissingNumber.Interfaces;

namespace MissingNumber.Services;

/// <summary>
/// Provides an implementation of <see cref="IMissingNumberFinder"/> that
/// uses the arithmetic sum formula to find the missing number.
/// </summary>
public sealed class SumFormulaMissingNumberFinder : IMissingNumberFinder
{
    /// <summary>
    /// Finds the missing number in an array of distinct integers
    /// from the range [0, n] using the sum formula.
    /// ref. https://www.geeksforgeeks.org/maths/sum-of-natural-numbers/
    /// </summary>
    /// <param name="numbers">
    /// An array of <c>n</c> distinct integers where the elements are
    /// taken from the inclusive range [0, n], with exactly one number missing.
    /// </param>
    /// <returns>The missing number from the range [0, n].</returns>
    /// <exception cref="ArgumentNullException">Thrown if the input array is null.</exception>
    /// <exception cref="ArgumentException">Thrown if the input array contains duplicate values.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the input array contains out of range values.</exception>
    public int FindMissingNumber(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentNullException(nameof(numbers), "Input array cannot be null.");
        }

        var n = numbers.Length;

        if (n != numbers.Distinct().Count())
        {
            throw new ArgumentException("Input array contains duplicate values.", nameof(numbers));
        }

        if (numbers.Any(x => x < 0 || x > n))
        {
            throw new ArgumentOutOfRangeException(nameof(numbers), $"All numbers must be in the range 0 to {n}.");
        }

        var expectedSum = n * (n + 1) / 2;
        var actualSum = numbers.Sum();
        return expectedSum - actualSum;
    }
}