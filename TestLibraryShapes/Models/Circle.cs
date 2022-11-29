using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibraryShapes.Models
{
    class Circle
    {
        public double R { get; set; }

        public Circle(double r)
        {
            this.R = r;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
