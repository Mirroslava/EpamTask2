using System;
namespace EpamTask2
{
    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
        public Rectangle(int x, int y ):base(x, y)
        {

        }
    }
}
