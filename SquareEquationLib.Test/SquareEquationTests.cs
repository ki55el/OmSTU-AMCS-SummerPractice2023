using Xunit;
using SquareEquationLib;

namespace XUnit.Coverlet.MSBuild;

public class UnitTest1
{
    [Fact]
    public void Solve_returnedRoots()
    {
        double[] expected = new double[] { -3, 2 };
        double[] actual = SquareEquation.Solve(1, 1, -6);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Solve_returnedRoot()
    {
        double[] expected = new double[] { 4 };
        double[] actual = SquareEquation.Solve(1, -8, 16);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Solve_returnedEmpty()
    {
        double[] expected = new double[] { };
        double[] actual = SquareEquation.Solve(2, 1, 4);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Solve_throwedArgumentException()
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(0, 2, 3));
    }

    [Theory]
    [InlineData(double.NaN, 2, 3)]
    [InlineData(1, double.PositiveInfinity, 3)]
    [InlineData(1, 2, double.NegativeInfinity)]
    public void Solve_InvalidInput(double a, double b, double c)
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(a, b, c));
    }
}