
using System;

namespace Figures
{
    interface IDrawable
    {
        void Draw();
        ConsoleColor Color { get; }
    }
}
