namespace Shapes.Figures.Common;

internal static class Polygons
{
    public static bool IsSidesLengthCorrect(IReadOnlyList<double> sides)
    {
        // Sum of all sides
        var sum = sides.Sum();
        return !sides.Any(x => x > sum - x);
    }
}
