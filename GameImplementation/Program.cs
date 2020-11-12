using System;

namespace GameImplementation
{
    class Program
    {
        static void Main(string[] args)
        { 
            Game g = Game.getCurrent();
            g.StartMe();
            Console.ReadLine();
        }
    } //random comment
}