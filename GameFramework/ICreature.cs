using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public interface ICreature
    {
        string FullName { get; set; }
        IDo AttackAction { get; set; }
        void RecieveDamage(int DamageRecieved);
        int GetDamage();
        int GetHealth();
    }
}
