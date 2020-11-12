using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GameFramework;
using GameImplementation.Enemies;
using GameImplementation.Levels;
using GameImplementation.Tiles;

namespace GameImplementation
{
    class Game : AbstractEngine
    {
        public static readonly int _width = 200, _height = 50;

        //funky workaround
        public BaseLevel CurrentLevel { get; set; }

        #region singleton implementation
        private static Game g;

        public static Game getCurrent()
        {
            if (g == null)
            {
                g = new Game("Dem Castles");
            }
            return g;
        }


        private Game(string name) : base(name)
        {
            Console.Title = Name;
            Console.SetWindowSize(_width, _height);
            Console.CursorVisible = false;

           // Start();
        }
        #endregion

        public void StartMe()
        {
            Start();
        }

        protected override void Start()
        {
            CurrentLevel = LevelFactory.LoadLevel(0);

            Draw();
        }

        override protected void Draw()
        {
            Console.Clear();

            List<BaseTile> backgroundTiles = CurrentLevel.GetEntities().FindAll(o => o.DrawLayer == Layer.Background);
            List<BaseTile> floorTiles = CurrentLevel.GetEntities().FindAll(o => o.DrawLayer == Layer.Floor);
            List<BaseTile> entityTiles = CurrentLevel.GetEntities().FindAll(o => o.DrawLayer == Layer.Entity);
            List<BaseTile> playerTiles = CurrentLevel.GetEntities().FindAll(o => o.DrawLayer == Layer.Player);

            foreach (var ent in backgroundTiles)
            {
                ent.Draw();
            }
            foreach (var ent in floorTiles)
            {
                ent.Draw();
            }
            foreach (var ent in entityTiles)
            {
                ent.Draw();
            }
            foreach (var ent in playerTiles)
            {
                ent.Draw();
            }

            if (CurrentLevel.GetHero().onTile != null)
            {
                Console.SetCursorPosition(0, 35);
                Console.Write("Info of tile you're standing on: ");
                Console.SetCursorPosition(0, 36);
                Console.Write(CurrentLevel.GetHero().onTile.myDescription.GetDescription());
            }
            Console.SetCursorPosition(0, 43);
            Console.Write("Hero stats: ");

            Console.SetCursorPosition(0, 44);
            Console.Write("HP: "+CurrentLevel.GetHero().GetHealth());
            Console.SetCursorPosition(0, 45);
            Console.Write("Damage: " + CurrentLevel.GetHero().GetDamage());
            Update();
        }

        override protected void Update()
        {
            //code smells bad here
            while (Console.KeyAvailable)
                Console.ReadKey(false);

            ConsoleKeyInfo input = Console.ReadKey();

            Hero h = CurrentLevel.GetHero();

            switch (input.Key)
            {
                case ConsoleKey.LeftArrow:
                    Vector2d left = new Vector2d(h.Position.X - 1, h.Position.Y);
                    h.Move(left, CurrentLevel.getTileAt((int)left.X, (int)left.Y));
                    break;
                case ConsoleKey.RightArrow:
                    Vector2d right = new Vector2d(h.Position.X + 1, h.Position.Y);
                    h.Move(right, CurrentLevel.getTileAt((int)right.X, (int)right.Y));
                    break;
                case ConsoleKey.UpArrow:
                    Vector2d up = new Vector2d(h.Position.X, h.Position.Y - 1);
                    h.Move(up, CurrentLevel.getTileAt((int)up.X, (int)up.Y));
                    break;
                case ConsoleKey.DownArrow:
                    Vector2d down = new Vector2d(h.Position.X, h.Position.Y + 1);
                    h.Move(down, CurrentLevel.getTileAt((int)down.X, (int)down.Y));
                    break;
                case ConsoleKey.Spacebar:
                    ActionTile a = h.onTile as ActionTile;
                    if (a != null)
                    {
                        a.getAction();
                    }
                    break;
                default:
                    break;
            }



            Draw();
        }
    }
}
