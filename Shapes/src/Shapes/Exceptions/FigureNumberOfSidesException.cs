namespace Shapes.Exceptions;

public class FigureNumberOfSidesException : Exception
{
    private const string message = "Incorrect number of sides.";

    public FigureNumberOfSidesException() : base(message) { }
}
