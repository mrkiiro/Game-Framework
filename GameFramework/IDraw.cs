using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public interface IDraw
    {
        void Draw();
    }
    public enum Layer
    {
        Background,
        Floor,
        Entity,
        Player
    }
}
