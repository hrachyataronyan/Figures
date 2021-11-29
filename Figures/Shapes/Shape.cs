using System;

namespace Figures.Shapes
{
    abstract class Shape : IDrawable
    {
        public ConsoleColor Color { get; protected set; }

        public abstract void Draw();
    }
}
