using GameFramework;
using GameImplementation.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Tiles
{
    public abstract class ActionTile : BaseTile, IDo
    {
        public ActionTile(string name, Vector2d position) : base(name, position)
        {
        }
        public abstract void getAction();
    }
}
