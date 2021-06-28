using DesignPatternsPlayground.Prototype.Interfaces;
using System;

namespace DesignPatternsPlayground.Prototype.Abstract
{
    public abstract class Shape:ICloneable<Shape>
    {
        private int PosX;
        private int PosY;

        public Shape(int posX,int posY) {
            PosX = posX;
            PosY = posY;
        }

        public Shape(Shape shape)
        {
            PosX = shape.PosX;
            PosY = shape.PosY;
        }

        public abstract Shape Clone();
    }
}
