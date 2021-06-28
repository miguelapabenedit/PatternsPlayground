using DesignPatternsPlayground.Prototype.Abstract;

namespace DesignPatternsPlayground.Prototype.Concrete
{
    public class Rectangle : Shape
    {
        public int Lenght { get; set; }
        public int Width { get; set; }

        public Rectangle(int lenght,int width,int posX,int posY):base(posX,posY) 
        {
            this.Lenght = lenght;
            this.Width = width;
        }

        public Rectangle(Rectangle source):base(source)
        {
            this.Lenght = source.Lenght;
            this.Width = source.Width;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
