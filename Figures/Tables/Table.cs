using System;

namespace Figures.Tables
{
    public class Table : IDrawable
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public ConsoleColor Color { get; protected set; }

        public void Draw()
        {
            Console.WriteLine("Table");
        }
    }
}
