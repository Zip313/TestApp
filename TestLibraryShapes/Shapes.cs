using System;
using System.Drawing;
using TestLibraryShapes.Models;

namespace TestLibraryShapes
{
    public static class Shapes
    {
        /// <summary>Возвращает площадь круга по радиусу</summary>        
        public static double GetSquare(double r)
        {
            return new Models.Circle(r).GetSquare();
        }
        /// <summary>Возвращает площадь треугольника по сторонам</summary>
        public static double GetSquare(double ab, double bc, double ca)
        {
            return new Models.Rectangle(ab, bc, ca).GetSquare();
        }
        /// <summary>Возвращает площадь треугольника по вершинам</summary>
        public static double GetSquare(Point a, Point b, Point c)
        {
            return new Models.Rectangle(a, b, c).GetSquare();
        }

        /// <summary>Проверяет является ли треугольник прямоугольным по сторонам</summary>
        public static bool IsRectRight(double ab, double bc, double ca)
        {
            return new Models.Rectangle(ab, bc, ca).IsRight;
        }
        /// <summary>Проверяет является ли треугольник прямоугольным по вершинам</summary>
        public static bool IsRectRight(Point a, Point b, Point c)
        {
            return new Models.Rectangle(a, b, c).IsRight;
        }
    }

    
}
