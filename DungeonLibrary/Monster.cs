using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character 
    {
        private int _minDamage;

        public int MaxDamage { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public Monster() { }

        public Monster(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Monster(string name, string description, int maxHealth, int life, int block, int hitChance, int minDamage, int maxDamage):base(name, description,maxHealth, life, block, hitChance)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }


        public override string ToString()
        {
            return string.Format("\nName: {0}" +
                "\nDescription: {1}" +
                "\nMax Health: {2}" +
                "\nCurrent Health: {3}" +
                "\nBlock: {4}" +
                "\nHit Chance: {5}" +
                "\nMin Damage: {6}" +
                "\nMax Damage: {7}", Name, Description, MaxHealth, Life, Block, HitChance, MinDamage, MaxDamage);
        }
    }
}
