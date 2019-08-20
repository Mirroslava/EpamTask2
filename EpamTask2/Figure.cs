using System;
namespace EpamTask2
{
   public abstract class  Figure : IDrawable 
    {
       
        public abstract void Draw();

        public virtual void DrawVirtual()
        {
            Console.WriteLine("Draw");
        }
        readonly int X;
        readonly int Y;
       public Figure (int x, int y )
        {
            X = x;
            Y = y; 
        }


        public virtual void DrawI()
        {
            Console.WriteLine("DrawI");
        }

        public virtual void DrawAll(params IDrawable[] array)
        {
            foreach ( var elem in array)
            {
                elem.DrawI();
            }
        }
    }
}
