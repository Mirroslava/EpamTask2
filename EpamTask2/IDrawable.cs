using System;
namespace EpamTask2
{
    public interface IDrawable
    {

        void DrawI();
        void DrawAll(params IDrawable[] array);
    }
}
