using GameFramework;
using GameImplementation.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation
{
    public class Hero : BaseTile, ICreature
    {

        public BaseTile onTile;

        private int _baseHealth;

        public string FullName { get; set; }
        public IDo AttackAction { get; set; }

        public Hero(string name, Vector2d position) : base(name, position)
        {
            FullName = "Hero";
            Foreground = ConsoleColor.Green;
            DrawLayer = Layer.Player;
            AttackAction = new Attack(this, null);
            _baseHealth = 100;
        }

        private bool canGoTo(BaseTile b)
        {
            return b.Walkable;
        }

        public void Move(Vector2d newPos, BaseTile t)
        {
            if (canGoTo(t))
            {
                Position = newPos;
                onTile = t;
            }
            // Cast til Base Enemy, hvis den tile jeg står på er en BaseEnemy
            BaseEnemy e = onTile as BaseEnemy;
            if(e != null)
            {
                onTile = e;
                AttackAction = new Attack(this, e);
            }
            //
        }

        public void RecieveDamage(int DamageRecieved)
        {
            _baseHealth -= DamageRecieved;
        }

        public int GetDamage()
        {
            return 5;
        }

        public int GetHealth()
        {
            return _baseHealth;
        }
    }
}
