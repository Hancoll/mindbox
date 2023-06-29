namespace Shapes.Exceptions;

public class FigureSidesLengthException : Exception
{
    private const string message = "Incorrect length of sides.";

    public FigureSidesLengthException() : base(message) { }
}
