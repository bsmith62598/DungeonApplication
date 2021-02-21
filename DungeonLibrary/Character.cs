using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        private int _life;

        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxHealth { get; set; }
        public int Block { get; set; }
        public int HitChance { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxHealth)
                {
                    _life = value;
                }
                else
                {
                    _life = 1;
                }
            }
        }

        public Character() { }

        public Character(string name, string description, int maxHealth, int life, int block, int hitChance )
        {
            MaxHealth = maxHealth;
            Name = name;
            Description = description;
            Life = life;
            Block = block;
            HitChance = hitChance;
        }
    }
}
