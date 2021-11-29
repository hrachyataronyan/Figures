using System;

namespace Shapes.Colors
{
    class Blue : IColorable
    {
        public void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
