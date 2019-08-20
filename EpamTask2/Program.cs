using System;

namespace EpamTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Squere squere = new Squere(1,2);
            squere.Draw();

            Rectangle rectangle = new Rectangle(1,2);
            rectangle.Draw();
        }
    }
}