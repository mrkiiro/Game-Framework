using GameFramework;
using GameImplementation.Tiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Enemies
{
    public abstract class BaseEnemy : ActionTile, ICreature
    {
        protected abstract int Health { get; set; }
        protected BaseEnemy(string fullName, Vector2d position, Layer dLayer = Layer.Entity, string name = "e") : base(name, position)
        {
            DrawLayer = Layer.Entity;
            FullName = fullName;
            AttackAction = new Attack(this, Game.getCurrent().CurrentLevel.GetHero());
            myDescription = new UpdateableDescription(myDescription.GetDescription());
        }
        public override void getAction()
        {
            AttackAction.getAction();
        }

        public abstract string FullName { get; set; }
        public IDo AttackAction { get; set; }

        public abstract int GetDamage();
        public abstract int GetHealth();
        public void RecieveDamage(int DamageRecieved)
        {
            Health -= DamageRecieved;

            (myDescription as UpdateableDescription)?.updateDescription(getNewDescription());

            if (Health <= 0)
            {
                Game.getCurrent().CurrentLevel.RemoveTile(this);
            }
        }
        protected abstract string getNewDescription();
    }
}
