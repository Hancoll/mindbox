using Shapes.Exceptions;
using Shapes.Figures.Common;

namespace Shapes.Figures;

public class Triangle : IFigure
{
    private double[] sides = null!;

    public IReadOnlyList<double> Sides
    {
        get => sides;

        set
        {
            if (value is null) throw new ArgumentNullException();

            if (value.Count != 3) throw new FigureNumberOfSidesException();

            if (!Polygons.IsSidesLengthCorrect(value)) throw new FigureSidesLengthException();

            sides = value.ToArray();
        }
    }

    public double Square
    {
        get
        {
            // Heron's formula
            var p = Sides.Aggregate((x, y) => x + y) / 2;
            var square = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            return square;
        }
    }

    /// <returns>true if triangle is right triangle.</returns>
    public bool IsRight()
    {
        var squareSum = Sides.Sum(x => x * x);
        return Sides.Any(x => x * x == squareSum / 2);
    }
}
