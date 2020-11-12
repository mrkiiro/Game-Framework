using System;
using System.Collections.Generic;
using System.Text;
using GameFramework;
using GameImplementation.Enemies;
using GameImplementation.Tiles;

namespace GameImplementation
{
    static class BaseTileGenerator
    {
        public static BaseTile GenerateBaseTile(string s, Vector2d tilePosition, ColorScheme c = new ColorScheme())
        {
            BaseTile t;
            switch(s)
            {
                case "#":
                    t = new Wall(s, tilePosition);
                    break;
                case "o":
                    t = new Hero(s, tilePosition);
                    break;
                case "g":
                    t = new Goal(s, tilePosition);
                    break;
                case "k":
                    t = new GreenWall(s, tilePosition);
                    break;
                case "S":
                    t = new Slime(10, tilePosition);
                    break;
                default: //behøver ikke at skabe en tom tile, men gør det fordi..
                    t = new BaseTile(s, tilePosition);
                    break;
            }
            return t;
        }
    }
    public struct ColorScheme
    {
        public static ColorScheme standard = new ColorScheme(ConsoleColor.White, ConsoleColor.Black);
        public ConsoleColor foregColor { get; set; }
        public ConsoleColor backGColor { get; set; }

        public ColorScheme(ConsoleColor foreground, ConsoleColor background)
        {
            foregColor = foreground;
            backGColor = background;
        }
    }
}
