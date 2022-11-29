using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TestLibraryShapes.Models
{
    class Rectangle
    {
        private Point CornerA { get; set; }
        private Point CornerB { get; set; }
        private Point CornerC { get; set; }

        private double SideAB { get; set; }
        private double SideBC { get; set; }
        private double SideCA { get; set; }
        public bool IsRight
        {
            get => (SideAB == SideBC && SideBC == SideCA);
        }

        public Rectangle(Point a, Point b, Point c)
        {            
            this.CornerA = a;
            this.CornerB = b;
            this.CornerC = c;
            this.SideAB = Math.Sqrt(Math.Pow((CornerB.X - CornerA.X), 2) + Math.Pow((CornerB.Y - CornerA.Y), 2));
            this.SideBC = Math.Sqrt(Math.Pow((CornerC.X - CornerB.X), 2) + Math.Pow((CornerC.Y - CornerB.Y), 2));
            this.SideCA = Math.Sqrt(Math.Pow((CornerA.X - CornerC.X), 2) + Math.Pow((CornerA.Y - CornerC.Y), 2));
        }

        public Rectangle(double ab, double bc, double ca)
        {
            
            this.SideAB = ab;
            this.SideBC = bc;
            this.SideCA = ca;
        }

        public double GetSquare()
        {
            try
            {
                double p = (SideAB + SideBC + SideCA) / 2;
                double res = Math.Sqrt(p * (p - SideAB) * (p - SideBC) * (p - SideCA));
                return res;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
