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

        }
    }
}
