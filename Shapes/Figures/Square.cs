using Shapes.Colors;
using System;

namespace Shapes.Figures
{
    class Square : Shape
    {
        uint _size { get; }
        public override void Draw()
        {
            Console.WriteLine($"Square: size {_size}");
        }
        public Square(uint size, IColorable _color)
        {
            _color.SetColor();
            _size = size;
        }
    }
}
