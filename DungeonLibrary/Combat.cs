using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(1500);
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {

                int damage = attacker.CalcDamage();

                defender.Life -= damage;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed");
            }
        }

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
            else
            {
                if (player.Level < 5)
                {
                    player.EXP += 300;
                }
                if (player.Level >= 5 && player.Level < 10)
                {
                    player.EXP += 600;
                }
            }
        }
    }
}
