using MissingNumber.Interfaces;
using MissingNumber.Services;

namespace MissingNumber.UnitTest.Services;

public abstract class MissingNumberFinderSpecification(string impl)
{
    protected readonly IMissingNumberFinder MissingNumberFinder = impl switch
    {
        "Sum" => new SumFormulaMissingNumberFinder(),
        _ => throw new ArgumentException("Unknown implementation", nameof(impl))
    };
}