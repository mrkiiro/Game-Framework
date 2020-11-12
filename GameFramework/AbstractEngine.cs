using System;
using System.Timers;

namespace GameFramework
{
    public abstract class AbstractEngine
    {
        protected int TickCount = 0;
        protected string Name;
        protected AbstractEngine(string name)
        {
            Name = name;
        }

        protected abstract void Start();
        protected abstract void Update();
        protected abstract void Draw();
    }
}
