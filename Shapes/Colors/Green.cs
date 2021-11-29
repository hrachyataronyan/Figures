using System;

namespace Shapes.Colors
{
    class Green : IColorable
    {
        public void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
