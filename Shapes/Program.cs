using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<IDraw> draws = new List<IDraw> { new Triangle(10),
            new Rectangle(30, 40),
            new Square(15)
            };

            foreach (var draw in draws)
            {
                draw.Drawing();
            }
            
            Console.WriteLine();
        }
    }

    interface IDraw
    {
        void Drawing();
    }
    abstract class Draw : IDraw
    {
        public abstract void Drawing();
    }

    class Triangle : Draw
    {
        uint _size { get; set; }
        public override void Drawing()
        {
            Console.WriteLine($"Triangle: size {_size}");
        }
        public Triangle(uint size)
        {
            _size = size;
        }
    }
    class Rectangle : Draw
    {
        uint _sizeX { get; set; }
        uint _sizeY { get; set; }
        public override void Drawing()
        {
            Console.WriteLine($"Rectangle: sizes X={_sizeX}, Y={_sizeY}");
        }
        public Rectangle(uint sizeX, uint sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
        }
    }
    class Square : Draw
    {
        uint _size { get; set; }
        public override void Drawing()
        {
            Console.WriteLine($"Square: size {_size}");
        }
        public Square(uint size)
        {
            _size = size;
        }
    }

    class Shape : Draw
    {
        Draw _draw { get; set; }
        public Shape(Draw draw)
        {
            _draw = draw;
        }
        public override void Drawing()
        {
            _draw.Drawing();
        }
    }
}
