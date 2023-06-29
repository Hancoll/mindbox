namespace Shapes.Figures;

public partial class Circle : IFigure
{
    public double Radius { get; set; }

    public double Square => Math.Pow(Math.PI * Radius, 2);
}

