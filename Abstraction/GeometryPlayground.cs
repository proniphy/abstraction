using Abstraction.Figures;
using System;

namespace Abstraction
{
    public class GeometryPlayground
    {
        static void Main(string[] args)
        {
            var newCircle = new Circle(5d);
            var newTriangle = new Triangle(2d, 3d);

            IFigure[] allFugures = { newCircle, newTriangle };

            foreach (IFigure figure in allFugures)
            {
                figure.CalculateSurface();
            }

            if (newCircle is IFigure)
            {
                Console.WriteLine($"{newCircle.GetType()} is IFigure");
            }
        }
    }
}
