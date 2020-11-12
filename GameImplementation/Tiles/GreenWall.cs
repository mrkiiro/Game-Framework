using GameFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Tiles
{
    class GreenWall : Wall
    {
        public GreenWall(string name, Vector2d position) : base(name, position)
        {
            Background = ConsoleColor.Green;
            Representation = '#';
        }
    }
}
