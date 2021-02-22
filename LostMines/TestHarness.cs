using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace LostMines
{
    public class TestHarness
    {
        static void Main(string[] args)
        {

            Weapon w1 = new Weapon("Long Sword", "A mundane iron sword", 10, 3, 10);

            Player p1 = new Player("Man", "The Player", 40, 40, 35, 40, Class.Warrior, w1, 1, 0, Race.Elf);
            Console.WriteLine(p1);
            
            
        }
    }
}
