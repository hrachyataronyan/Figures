using Figures.Colors;
using System;

namespace Figures.Shapes
{
    class Square : Rectangle
    {
        public Square(IColorable _color)
            : base(_color)
        { }

        private uint _sizeX;
        public sealed override uint SizeX 
        { 
            get => _sizeX;
            set 
            {
                _sizeX = value;
                _sizeY = value;
            }
        }

        private uint _sizeY;
        public sealed override uint SizeY
        {
            get => _sizeY;
            set
            {
                _sizeX = value;
                _sizeY = value;
            }
        }
    }
}
