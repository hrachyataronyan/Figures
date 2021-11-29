using Shapes.Colors;
using Shapes.Figures;
using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            new Triangle(10, new Green()).Draw();
            new Square(15, new Blue()).Draw();
            new Rectangle(30, 40, new Red()).Draw();            
            new Square(15, new Green()).Draw();
        }
    }    
}
