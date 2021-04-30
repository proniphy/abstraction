using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    interface IFigure
    {
        void SetStartingPoint(double x, double y);
        double CalculateSurface();
    }
}
