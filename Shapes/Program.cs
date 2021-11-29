using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {   
            var shapes = new List<Shape>
            {
                new Triangle(10),
                new Rectangle(30, 40),
                new Square(15)
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("---===Second logic===---");

            var drows = new List<IDrawable>
            {
                new Draws(new Triangle(10)),
                new Draws(new Rectangle(30, 40)),
                new Draws(new Square(15))                
            };

            foreach (var drow in drows)
            {
                drow.Draw();
            }
        }
    }

    interface IDrawable
    {
        void Draw();
    }
    abstract class Shape : IDrawable
    {
        public abstract void Draw();
    }
    class Triangle : Shape
    {
        uint _size { get; }
        public override void Draw()
        {
            Console.WriteLine($"Triangle: size {_size}");
        }
        public Triangle(uint size)
        {
            _size = size;
        }
    }
    class Rectangle : Shape
    {
        uint _sizeX { get; }
        uint _sizeY { get; }
        public override void Draw()
        {
            Console.WriteLine($"Rectangle: sizes X={_sizeX}, Y={_sizeY}");
        }
        public Rectangle(uint sizeX, uint sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
        }
    }
    class Square : Shape
    {
        uint _size { get; }
        public override void Draw()
        {
            Console.WriteLine($"Square: size {_size}");
        }
        public Square(uint size)
        {
            _size = size;
        }
    }
    class Draws : Shape
    {
        Shape _shape { get; }
        public Draws(Shape shape)
        {
            _shape = shape;
        }
        public override void Draw()
        {
            _shape.Draw();
        }
    }
}
