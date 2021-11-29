using Figures.Colors;
using System;

namespace Figures.Shapes
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
            _size = size;
        }
    }
}
