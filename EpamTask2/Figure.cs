using System;
namespace EpamTask2
{
   public abstract class  Figure
    {
       
        public abstract void Draw();
        readonly int X;
        readonly int Y;
       public Figure (int x, int y )
        {
            X = x;
            Y = y; 
        }
    }
}
