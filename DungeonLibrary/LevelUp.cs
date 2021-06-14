using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class LevelUp
    {
        public static void DoLevelUp(Player player)
        {
            bool exit = false;
            if (player.EXP <= 600 && player.Level <5)
            {
                Console.WriteLine("Please pick an attribute to level up." +
                    "\nB) for Block Chance." +
                    "\nM) for Max Health." +
                    "\nH) for Hit Chance.");
                ConsoleKey userChoice = Console.ReadKey(true).Key;
                switch (userChoice)
                {
                    case ConsoleKey.B:
                        Console.WriteLine("Block Chance");
                        player.HitChance += player.HitChance + 5;
                        player.Level += 1;
                        exit = true;
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("Max Health");
                        player.MaxHealth += player.MaxHealth + 10;
                        player.Life = player.MaxHealth;
                        player.Level += 1;
                        exit = true;
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("Hit Chance");
                        player.HitChance += player.HitChance + 5;
                        player.Level += 1;
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please Choose a valid option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Sorry, you haven't quite gotten enough EXP to level up, try agian later.");
                exit = true;
            }
        }
    }
}
