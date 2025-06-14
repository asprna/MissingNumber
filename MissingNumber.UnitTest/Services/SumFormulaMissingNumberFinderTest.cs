using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MissingNumber.UnitTest.Services;

[TestClass]
public sealed class SumFormulaMissingNumberFinderTest() : MissingNumberFinderSpecification("Sum")
{
    [DataTestMethod]
    [DataRow(new int[] { 3, 0, 1 }, 2)]
    [DataRow(new int[] { 1, 2, 3, 4 }, 0)]
    [DataRow(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    [DataRow(new int[] { 0, 1, 2, 3, 4 }, 5)]
    public void ShouldReturnCorrectMissingNumber(int[] input, int expected)
    {
        // Arrange & Act
        var result = this.MissingNumberFinder.FindMissingNumber(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShouldThrowArgumentNullExceptionWhenInputIsNull()
    {
        // Arrange & Act
        var ex = Assert.ThrowsException<ArgumentNullException>(() => this.MissingNumberFinder.FindMissingNumber([]));

        // Assert
        StringAssert.Contains(ex.Message, "Input array cannot be null");
    }

    [TestMethod]
    public void ShouldThrowArgumentExceptionWhenInputHasDuplicates()
    {
        // Arrange & Act
        var ex = Assert.ThrowsException<ArgumentException>(() => this.MissingNumberFinder.FindMissingNumber([0, 1, 1, 2]));

        // Assert
        StringAssert.Contains(ex.Message, "Input array contains duplicate values");
    }

    [TestMethod]
    public void ShouldThrowArgumentOutOfRangeExceptionWhenInputHasOutOfRageValues()
    {
        // Arrange & Act
        var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() => this.MissingNumberFinder.FindMissingNumber([0, 4]));

        // Assert
        StringAssert.Contains(ex.Message, "All numbers must be in the range 0 to 2.");
    }
}