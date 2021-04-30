using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Figures
{
    class Circle : IPoint, IFigure
    {
        public double X { get; set; }
        public double Y { get; set; }

        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void SetStartingPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double CalculateSurface()
        {
            double surface = Math.PI * (radius * radius);
            Console.WriteLine($"Circle has surface: {surface}");

            return surface;
        }
    }
}
