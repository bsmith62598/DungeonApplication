using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Werewolf : Monster
    {
        public DateTime ChangeTime { get; set; }

        public Werewolf(string name, string description, int maxHealth, int life, int block, int hitChance, int minDamage, int maxDamage):base(name, description, maxHealth, life, block, hitChance, minDamage, maxDamage)
        {
            ChangeTime = DateTime.Now;
            if (ChangeTime.Hour >= 19 && ChangeTime.Hour <= 23)
            {
                MaxHealth += 25;
                Life += 25;
                HitChance -= 20;
                MaxDamage += 15;
                MinDamage += 15;
                Block += 13;
            }
        }
    }
}
