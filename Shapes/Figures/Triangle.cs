using Shapes.Colors;
using System;

namespace Shapes.Figures
{
    class Triangle : Shape
    {
        uint _size { get; }

        public override void Draw()
        {
            Console.WriteLine($"Triangle: size {_size}");
        }

        public Triangle(uint size, IColorable _color)
        {
            _color.SetColor();
            _size = size;
        }
    }
}
