using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        private int _minDamage;

        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxDamage { get; set; }
        public int BonusHitChance { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value <= MaxDamage && value >= 1)
                {
                    _minDamage = value;
                }
            }
        }

        public Weapon(string name, string description, int maxDamage, int minDamage, int bonusHitChance)
        {
            Name = name;
            Description = description;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
        }

        public override string ToString()
        {
            return string.Format("\nWeapon Name: {0}" +
                "\nWeapon Description: {1}" +
                "\nDamage {2} to {3}" +
                "\nBonus Hit Chance: {4}", Name, Description, MinDamage, MaxDamage, BonusHitChance);
        }
    }
}
