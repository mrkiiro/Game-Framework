using GameFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameImplementation.Enemies
{
    public class Slime : BaseEnemy
    {
        public Slime(int health, Vector2d position, string fullName = "Slime") : base(fullName, position)
        {
            FullName = fullName;
            Health = health;
            myDescription = new UpdateableDescription($"This is a slime monster! Carefull, if you hurt it, it will hurt you back! \n" +
                $"current hp: {Health} \n" +
                $"Press Spacebar to attack");
            Foreground = ConsoleColor.Red;
        }

        public override string FullName { get; set; }
        protected override int Health { get; set; }

        public override int GetDamage()
        {
            return 10;
        }

        public override int GetHealth()
        {
            return Health;
        }

        protected override string getNewDescription()
        {
            return $"This is a slime monster! Carefull, if you hurt it, it will hurt you back! \n" +
                $"current hp: {Health} \n" +
                $"Press Spacebar to attack";
        }
    }
}
