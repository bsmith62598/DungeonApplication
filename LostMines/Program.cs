using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace LostMines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lost Mines of Averice";
            Console.WriteLine("Your journey into the mines begins...");
            int score = 0;

            #region Weapons
            Weapon w1 = new Weapon("Dagger", "A compact dagger made of iron", 10, 1, 40);
            Weapon w2 = new Weapon("Long Sword", "A simple longsword made of iron", 20, 3, 10);
            Weapon w3 = new Weapon("Battle Axe", "A sturdy two handed battle axe", 40, 10, -15);
            Weapon w4 = new Weapon("Quarter Staff", "An ornate staff made of a very sturdy wood", 25, 4, 20);
            #endregion

            #region Monsters
            Monster m1 = new Monster("Rat", "A small rat", 10, 10, 65, 70, 1, 2);
            Monster m2 = new Monster("Ooze", "A gelatenous ooze that smells real bad", 20, 20, 40, 50, 1, 15);
            Werewolf wolf1 = new Werewolf("Ralph", "A seemingly normal man", 45, 45, 30, 50, 2, 7);
            Vampire v1 = new Vampire("Straad", "A very pale man", 40, 40, 50, 60, 1, 5);
            #endregion

            #region Monster List
            List<Monster> monsters = new List<Monster> { m1, m2, v1, wolf1 };
            #endregion

            #region Player Creation
            Player p1 = new Player();
            #region Player Name
            Console.WriteLine("Please enter your character's name.");
            p1.Name = Console.ReadLine();
            #endregion
            #region Player Class
            bool classPick = false;
           do
            {
            Console.WriteLine("Now pick your class. The Choices are: \n" +
                "R) Rouge" +
                "\nB) Barbarian" +
                "\nW) Warrior" +
                "\nM) Monk");
            
            ConsoleKey classChoice = Console.ReadKey(true).Key;
            if (classChoice == ConsoleKey.R)
            {
                p1.Class = Class.Rouge;
                    classPick = true;
            }
            if (classChoice == ConsoleKey.B)
            {
                p1.Class = Class.Barbarian;
                    classPick = true;
            }
            if (classChoice == ConsoleKey.W)
            {
                p1.Class = Class.Warrior;
                    classPick = true;
            }
            if (classChoice == ConsoleKey.M)
            {
                p1.Class = Class.Monk;
                    classPick = true;
            }
           } while (!classPick);
            #endregion
            #region Player Race
            bool playerRace = false;
            do
            {
                Console.WriteLine("Please Choose a Race:" +
                    "\nH) Human" +
                    "\nE) Elf" +
                    "\nO) Orc" +
                    "\nL) Lizzard Folk" +
                    "\nD) Dwarf" +
                    "\nG) Gnome");
                ConsoleKey raceChoice = Console.ReadKey(true).Key;
                if (raceChoice == ConsoleKey.H)
                {
                    p1.Race = Race.Human;
                    playerRace = true;
                }
                if (raceChoice == ConsoleKey.E)
                {
                    p1.Race = Race.Elf;
                    playerRace = true;
                }
                if (raceChoice == ConsoleKey.O)
                {
                    p1.Race = Race.Orc;
                    playerRace = true;
                }
                if (raceChoice == ConsoleKey.L)
                {
                    p1.Race = Race.LizardFolk;
                    playerRace = true;
                }
                if (raceChoice == ConsoleKey.D)
                {
                    p1.Race = Race.Dwarf;
                    playerRace = true;
                }
                if (raceChoice == ConsoleKey.G)
                {
                    p1.Race = Race.Gnome;
                    playerRace = true;
                }
            } while (!playerRace);
            #endregion
            #region Player Weapon
            if (p1.Class == Class.Barbarian)
            {
                p1.Equipment = w3;
                p1.Level = 1;
                p1.MaxHealth = 25;
                p1.Life = 25;
                p1.Block = 40;
                p1.HitChance = 15;
                p1.EXP = 0;
            }
            if (p1.Class == Class.Monk)
            {
                p1.Level = 1;
                p1.MaxHealth = 25;
                p1.Life = 25;
                p1.Block = 50;
                p1.HitChance = 35;
                p1.EXP = 0;
                p1.Equipment = w4;
            }
            if (p1.Class == Class.Warrior)
            {
                p1.Equipment = w2;
                p1.Level = 1;
                p1.MaxHealth = 30;
                p1.Life = 30;
                p1.Block = 35;
                p1.HitChance = 30;
                p1.EXP = 0;
            }
            if (p1.Class == Class.Rouge)
            {
                p1.Level = 1;
                p1.MaxHealth = 15;
                p1.Life = 15;
                p1.Block = 55;
                p1.HitChance = 40;
                p1.EXP = 0;
                p1.Equipment = w1;
            }
            #endregion
            
            #endregion
            bool exit = false;
            Console.Clear();
            do
            {
                Console.WriteLine(GetRoom());

                //TODO 4. Create a monster for the room - learn about creating objects and then randomly selecting one.
                Random rand = new Random();
                int randomNumber = rand.Next(monsters.Capacity);
                Monster monster = monsters[randomNumber];
                Console.WriteLine("A Monster Appears!! " + monster.Name);

                bool reload = false;
                do
                {
                    #region User Menu
                    Console.Write("\n\nPlease Choose an Action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "L) Level Up \n\n" +
                        "X) Exit \n\n" +
                        "Current Score: {0}\n\n", score);
                    #endregion

                    #region User Choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    #endregion

                    Console.Clear();
                    #region Switch that runs functionality based on user choice
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack\n");
                            Combat.DoBattle(p1, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}\n", monster.Name);
                                Console.ResetColor();
                                reload = true;
                                score++;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.WriteLine("Run Away!!!\n");
                            //TODO 10. Build flee logic
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine("Player stats\n");
                            Console.WriteLine(p1);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine("Monster stats\n");
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Buh Bye\n");
                            exit = true;
                            break;

                        case ConsoleKey.L:
                            Console.WriteLine("Level up");
                            LevelUp.DoLevelUp(p1);
                            break;

                        default:
                            //TODO 14. Add EXP logic to character sheet. Take EXP away for messing up
                            Console.WriteLine("How even? It was only like 5 buttons and you messed up? Mistakes are costly in these mines.\n");
                            p1.EXP -= 100;
                            break;

                    }
                    #endregion


                } while (!reload && !exit);
            } while (!exit);
        }

        private static string GetRoom()
        {
            string[] rooms =
            {
                "A rusted portcullis stands just beyond the door. Looking into the room, you see three other exits, similarly blocked by portcullises. Four skeletons dressed in aged clothing and rusting armor lie on the floor in the room against the walls. They seem in poses of repose rather than violence.",
                "This narrow room at first appears to be a dead-end corridor, but then you note several metal plates on the walls set at about eye height. Looking more closely, you see that one of these plates is slid aside to reveal a peephole",
                " This chamber of well-laid stones holds a wide bas-relief of a pastoral scene. In it you see a mountain like Mount Waterdeep, except that Castle Waterdeep and the city are missing. Instead, a small fishing village is a short way from a walled complex with several tall towers.",
                "You open the door and before you is a dragon's hoard of treasure. Coins cover every inch of the room, and jeweled objects of precious metal jut up from the money like glittering islands in a sea of gold.\n You take a step into the room and your foot goes through the gold as if it isn't there, and all the gold and treasure fades away.",
                //DM Note: Taking one step in the room alerts the PCs to the disappointing truth.Their feet pass silently through the illusion of the coins to strike the solid floor beneath.                
                " Huge rusted metal blades jut out of cracks in the walls, and rusting spikes project down from the ceiling almost to the floor. This room may have once been trapped heavily, but someone triggered them, apparently without getting killed. The traps were never reset and now seem rusted in place.",
                "A stone throne stands on a foot-high circular dais in the center of this cold chamber. The throne and dais bear the simple adornments of patterns of crossed lines -- a pattern also employed around each door to the room.",
                "A huge iron cage lies on its side in this room, and its gate rests open on the floor. A broken chain lies under the door, and the cage is on a rotting corpse that looks to be a hobgoblin. Another corpse lies a short distance away from the cage. It lacks a head.",
                " A rusted portcullis stands just beyond the door. Looking into the room, you see three other exits, similarly blocked by portcullises. Four skeletons dressed in aged clothing and rusting armor lie on the floor in the room against the walls. They seem in poses of repose rather than violence."
            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = "**** NEW ROOM ****\n" + rooms[indexNbr] + "\n";
            return room;
        }
    }
}
