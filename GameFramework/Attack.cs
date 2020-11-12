using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public class Attack : IDo
    {
        private ICreature _enemy, _me;
        public Attack(ICreature me, ICreature enemy)
        {
            _enemy = enemy;
            _me = me;
        }
        public void setEnimy(ICreature c)
        {
            _enemy = c;
        }

        public void getAction()
        {
            _me.RecieveDamage(_enemy.GetDamage());
        }
    }
}
