namespace MissingNumber.Interfaces;

/// <summary>
/// Defines a contract for finding the missing number in an array
/// that contains distinct integers from the range 0 to n.
/// </summary>
public interface IMissingNumberFinder
{
    /// <summary>
    /// Finds the missing number in the given array.
    /// </summary>
    /// <param name="numbers">
    /// An array of distinct integers containing n elements from the range [0, n],
    /// with exactly one number missing.
    /// </param>
    /// <returns>
    /// The missing number from the range [0, n].
    /// </returns>
    int FindMissingNumber(int[] numbers);
}