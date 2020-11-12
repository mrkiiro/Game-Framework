using GameFramework;
using GameImplementation.Levels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Actions
{
    class ChangeLevel : IDo
    {
        public int _nextLevel { get; set; }
        public ChangeLevel(int nextLevel)
        {
            _nextLevel = nextLevel;
        }
        public void getAction()
        {
            Game.getCurrent().CurrentLevel = LevelFactory.LoadLevel(_nextLevel);
        }
    }
}
