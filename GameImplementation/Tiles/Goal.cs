using GameFramework;
using GameImplementation.Actions;
using GameImplementation.Levels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Tiles
{
    class Goal : ActionTile
    {
        public int nextLevel { get; set; }
        public Goal(string name, Vector2d position) : base(name, position)
        {
            myDescription = new basicDescription("Checkpoint reached - hit Space to go to next level! \n"
                +"Press space to go to next level!");
        }

        public override void getAction()
        {
            new ChangeLevel(nextLevel).getAction();
        }
    }
}
