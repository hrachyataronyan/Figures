using Figures.Colors;
using Figures.Shapes;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(new Red()) 
            {
                SizeX = 30,
                SizeY = 40
            };
            
            var tr = new Triangle(10, new Green());
            var sq = new Square(new Blue()) { SizeX = 15 };

            Paint(rectangle);
            Paint(tr);
            Paint(sq);

            var table = new Tables.Table { Row = 10, Column = 5 };
            Paint(table);
        }

        public static void Paint(IDrawable drawable)
        {
            drawable.Draw();
        }
    }
}
