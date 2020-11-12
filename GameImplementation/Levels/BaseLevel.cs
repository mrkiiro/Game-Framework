using GameFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32.SafeHandles;
using GameImplementation.Tiles;

namespace GameImplementation.Levels
{
    public class BaseLevel : Level
    {
        private List<BaseTile> entities;

        public static readonly string[] _levelString = new string[] {
            "#########################",
            "#    #     #            #",
            "#          #    ##### ###",
            "#  o #     #    #       #",
            "#    #          #   g   #",
            "#########################",
            };

        public BaseLevel(string[] _levelData) : base()
        {
            if (_levelData == null) _levelData = _levelString;
            entities = LoadEntities(_levelData);

            //set up goal to point to next level
            Goal g = (Goal)entities.Find(o => o.Representation == 'g');
            g.nextLevel = 1;
        }

        public static BaseLevel GenerateLevel(string[] _levelData)
        {
            return new BaseLevel(_levelData);
        }

        private List<BaseTile> LoadEntities(string[] _levelString)
        {
            List<BaseTile> ents = new List<BaseTile>();

            for (int x = 0; x < _levelString.Length; x++)
            {
                for (int y = 0; y < _levelString[0].Length; y++)
                {
                    BaseTile t = BaseTileGenerator.GenerateBaseTile(_levelString[x][y].ToString(), new Vector2d(y, x));
                    ents.Add(t);
                }
            }

            return ents;
        }

        public Hero GetHero()
        {
            return (Hero)entities.Find(o => o.Representation == 'o');
        }
        public List<BaseTile> GetEntities()
        {
            return entities;
        }
        public BaseTile getTileAt(int x, int y)
        {
            BaseTile t = entities.Find(o => o.Position.X == x && o.Position.Y == y);
            return t ?? new BaseTile(" ", new Vector2d(x, y));
        }
        public void RemoveTile(BaseTile t)
        {
            entities.Remove(t);
        }
    }
}
