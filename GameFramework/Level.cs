using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public abstract class Level
    {
        protected List<Entity> Entities { get; set; }
        public Level()
        {
                
        }
        public Level(List<Entity> entities){
            Entities = entities;
        }
    }
}

