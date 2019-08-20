using System;
namespace EpamTask2
{
    public class Squere : Figure 
    {
       
        public override void Draw()
        {
            Console.WriteLine("Squere");
        }
        public Squere(int x, int y) : base(x, y)
        {

        }
        public override void DrawVirtual()
        {
            Console.WriteLine("Squere");
        }
        public override void DrawI()
        {
            Console.WriteLine("Squere");
        }
    }
}
