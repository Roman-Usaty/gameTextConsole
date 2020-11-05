using System;
using System.Collections.Generic;
using System.Text;

namespace gemeTextConsole
{
    class EnemyTest : Enemy
    {
        private double regen = 1.4;
        
        public bool regeneration()
        {
            int health = GetHealth();
            if ( health < 100)
            {
                int regenHealth = Math.floor(health * 1.4);
                return true;
            } else
            {
                return false;
            }
        }
    }
}
