using Figures.Colors;
using System;

namespace Figures.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(IColorable color)
        {
            SizeX = 5;
            SizeY = 10;
        }

        public virtual uint SizeX { get; set; }
        public virtual uint SizeY { get; set; }

        public sealed override void Draw()
        {
            Console.WriteLine($"Rectangle: sizes X={SizeX}, Y={SizeY}");
        }
    }
}
