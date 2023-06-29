using Shapes.Figures;

namespace Shapes.UnitTests.Figures;

public class TriangleTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3d }, 0)]
    [InlineData(new[] { 3, 4, 5d }, 6)]
    public void Square_Triangle_ReturnsSquare(double[] sides, double square)
    {
        var triangle = new Triangle { Sides = sides };

        Assert.Equal(square, triangle.Square);
    }

    [Theory]
    [InlineData(new[] { 3, 4, 5d })]
    [InlineData(new[] { 5, 12, 13d })]
    public void IsRight_RightTriangle_ReturnsTrue(double[] sides)
    {
        var triangle = new Triangle { Sides = sides };

        Assert.True(triangle.IsRight());
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3d })]
    public void IsRight_NonRightTriangle_ReturnsFalse(double[] sides)
    {
        var triangle = new Triangle { Sides = sides };

        Assert.True(!triangle.IsRight());
    }
}
