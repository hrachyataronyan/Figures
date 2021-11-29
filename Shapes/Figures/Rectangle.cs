using Shapes.Colors;
using System;

namespace Shapes.Figures
{
    class Rectangle : Shape
    {
        uint _sizeX { get; }
        uint _sizeY { get; }
        public override void Draw()
        {
            Console.WriteLine($"Rectangle: sizes X={_sizeX}, Y={_sizeY}");
        }
        public Rectangle(uint sizeX, uint sizeY, IColorable _color)
        {
            _color.SetColor();
            _sizeX = sizeX;
            _sizeY = sizeY;
        }
    }
}
