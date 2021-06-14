using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public Class Class { get; set; }
        public Weapon Equipment { get; set; }
        public int Level { get; set; }
        public int EXP { get; set; }
        public Race Race { get; set; }


        public Player() { }

        public Player(string name, string description, int maxHealth, int life, int block, int hitChance, Class type, Weapon equipment, int level, int exp, Race race):base(name, description, maxHealth, life, block, hitChance)
        {
            Class = type;
            Equipment = equipment;
            Level = level;
            EXP = exp;
            Race = race;
            HitChance = hitChance + Equipment.BonusHitChance;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}" +
                "\nClass: {1}" +
                "\nRace: {2}" +
                "\nLevel: {3}" +
                "\nEXP: {8}" +
                "\nCurrent Health: {4}" +
                "\nHit Chance: {5}%" +
                "\nBLock: {6}" +
                "\nEquipped Weapon: {7}", Name, Class, Race, Level, Life, HitChance, Block, Equipment, EXP);
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + Equipment.BonusHitChance;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(Equipment.MinDamage, Equipment.MaxDamage + 1);
            return damage;
        }
    }
}
