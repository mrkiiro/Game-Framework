using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Levels
{
    class LevelFactory
    {
        public static BaseLevel LoadLevel(int i)
        {
            switch (i)
            {
                case 1:
                    return new LevelTest(LevelTest._levelString);
                default:
                    return new BaseLevel(BaseLevel._levelString);
            }
        }

    }
}
