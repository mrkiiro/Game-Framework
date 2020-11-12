using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public abstract class Entity
    {
        public Layer DrawLayer { get; set; }
        protected Entity(string name, Vector2d position, Layer dLayer = Layer.Background)
        {
            Name = name;
            Position = position;
        }
        public Vector2d Position { get; set; }
        protected string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    public struct Vector2d
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2d(float x, float y)
        {
            X = x;
            Y = y;
        }
        public Vector2d(int x, int y)
        {
            X = (float)x;
            Y = (float)y;
        }
    }
}
