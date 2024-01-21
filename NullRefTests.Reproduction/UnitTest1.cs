using Xunit;

namespace NullRefTests.Reproduction;

public class UnitTest1
{
    [Theory]
    [InlineData(new[]{ 0.5f, 0.5f })] // <----- CA1861: Prefer 'static readonly' fields over constant array arguments if the called method is called repeatedly and is not mutating the passed array
    public void GetEqualWeightsReturnsExpectedWeight(float[] someArray)
    {
        // Act
        return;
    }
}