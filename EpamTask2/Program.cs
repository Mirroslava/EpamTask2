using System;

namespace EpamTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Squere squere = new Squere(1,2);
            squere.Draw();
            squere.DrawVirtual();
            squere.DrawI();

            Rectangle rectangle = new Rectangle(1,2);
            rectangle.Draw();
            rectangle.DrawVirtual();
            rectangle.DrawI();
           // Figure figure = new Figure(1,2);
           // figure.DrawVirtual();

        }
    }
}