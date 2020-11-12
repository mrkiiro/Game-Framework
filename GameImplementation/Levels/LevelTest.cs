using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Levels
{
    class LevelTest : BaseLevel
    {
        public static readonly new string[] _levelString = new string[] {
            "#########################",
            "#                   #   #",
            "#                   # o #",
            "#                  gS   #",
            "#                   #   #",
            "#########################",
            };

        public LevelTest(string[] _levelData) : base(_levelData)
        {
        }
    }
}
