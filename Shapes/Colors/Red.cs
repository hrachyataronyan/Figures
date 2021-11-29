using System;

namespace Shapes.Colors
{
    class Red : IColorable
    {
        public void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
