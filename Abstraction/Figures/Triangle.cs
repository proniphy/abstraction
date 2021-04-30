using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Figures
{
    public class Triangle : IPoint, IFigure
    {
        public double X { get; set; }
        public double Y { get; set; }

        private double side, height;
        public Triangle(double side, double height)
        {
            this.side = side;
            this.height = height;
        }
        public double CalculateSurface()
        {
            double surface = (side * height) / 2;
            Console.WriteLine($"Triangle has surface {surface}");

            return surface;
        }

        public void SetStartingPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
