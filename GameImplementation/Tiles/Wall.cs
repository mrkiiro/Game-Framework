using GameFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Tiles
{
    class Wall : BaseTile
    {
        public Wall(string name, Vector2d position) : base(name, position)
        {
            Walkable = false;
            Background = ConsoleColor.Red;
        }
    }
}