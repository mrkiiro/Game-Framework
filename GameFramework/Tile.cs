using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public abstract class Tile : Entity, IDraw
    {
        public TileDescription myDescription { get; set; }
        public bool Walkable { get; set; }
        protected Tile(string name, Vector2d position, bool canWalk = true) : base(name, position)
        {
            myDescription = new basicDescription();
            Walkable = canWalk;
        }

        public abstract void Draw(IDraw context);
        public abstract void Draw();
    }
}
