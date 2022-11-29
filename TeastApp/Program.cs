using System;
using System.Drawing;
using TestLibraryShapes;

namespace TeastApp
{
    class Program
    {
        
        
        static void Main(string[] args)
        {   
            Console.WriteLine($"Square Rect.IsRight(2,2,2) ={Shapes.IsRectRight(2,2,2)}");
            Console.WriteLine($"Square Rect(2,3,3.605) = {Shapes.GetSquare(1, 2, 3.605551275463989d)}");
            Console.WriteLine($"Square Rect(new Point(1, 1), new Point(1, -1), new Point(-2, -1)) = {Shapes.GetSquare(new Point(1, 1), new Point(1, -1), new Point(-2, -1))}");
            Console.WriteLine($"Square Circle(r=4) = {Shapes.GetSquare(4)}");            
        }       

    }
    
}
