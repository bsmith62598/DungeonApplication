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
            Vampire vamp1 = new Vampire("Straad", "a vampire", 50, 50, 26, 37, 1, 25);
            Console.WriteLine(vamp1);

            Werewolf wolf1 = new Werewolf("wolfy", "wolfy boy", 30, 30, 30, 30, 30, 30);
            Console.WriteLine(wolf1);
        }
    }
}
