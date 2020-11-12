using System;
using System.Collections.Generic;
using System.Text;
using GameFramework;

namespace GameImplementation
{
    public class BaseTile : Tile
    {
        public char Representation { get; set; }
        public ConsoleColor Foreground { get; set; }
        public ConsoleColor Background { get; set; }

        public BaseTile(string name, Vector2d position) : base(name, position)
        {
            Representation = Name[0];
            Foreground = ConsoleColor.White;
            Background = ConsoleColor.Black;
        }
        
       
        public override void Draw()
        {
            if (Position.X < 0 || Position.Y < 0 || Position.X > Game._width || Position.Y > Game._height) return; //only draw tile if within console window.
            Console.SetCursorPosition((int)Position.X, (int)Position.Y);
            Console.ForegroundColor = Foreground;
            Console.BackgroundColor = Background;
            Console.Write(Representation);
        }

        //this is really not usefull
        public override void Draw(IDraw context)
        {
            throw new NotImplementedException();
        }
    }
}