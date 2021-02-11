﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMines
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the program that will control the flow of the overall experience for the user. All calsses will be created in separate files and referred to in this program to allow us to use instances of monsters, players, weapons, etc.
            Console.Title = "Lost Mines of Averice";
            Console.WriteLine("Your journey into the mines begins...");
            int score = 0;

            //TODO 1. Create the player - need to create a class for this, as well as an instance of a weapon.

            //TODO 2. Create a loop for the room and monster.
            bool exit = false;

            do
            {
                //Enter a room
                //TODO 3. Call GetRoom()
                Console.WriteLine(GetRoom());

                //TODO 4. Create a monster for the room - learn about creating objects and then randomly selecting one.

                //TODO 5. loop for the room
                bool reload = false;
                do
                {
                    //TODO 6. Create a menu
                    #region User Menu
                    Console.Write("\n\nPlease Choose an Action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit \n\n" +
                        "Current Score: {0}\n\n", score);
                    #endregion

                    //TODO 7. Capture user choice.
                    #region User Choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //Above will execute upon input without having to hit enter
                    #endregion

                    //TODO 8. Clear the console and build the switch based on userChoice
                    Console.Clear();
                    #region Switch that runs functionality based on user choice
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack\n");
                            //TODO 9. Build attack logic
                            break;

                        case ConsoleKey.R:
                            Console.WriteLine("Run Away!!!\n");
                            //TODO 10. Build flee logic
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine("Player stats\n");
                            //TODO 11. Input Player stats
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine("Monster stats\n");
                            //TODO 12. Input Monster stats
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Buh Bye\n");
                            exit = true;
                            //TODO 13. Add exit logic
                            break;

                        default:
                            //TODO 14. Add EXP logic to character sheet. Take EXP away for messing up
                            Console.WriteLine("How even? It was only like 5 buttons and you messed up? Mistakes are costly in these mines.\n");
                            break;

                    }
                    //TODO 15. Handle Player Life
                    #endregion


                } while (!reload && !exit);
            } while (!exit);
        }

        //TODO 16. Create a GetRoom() and plug it in to the todo above

        private static string GetRoom()
        {
            //Create an array of room descriptions - string datatype
            string[] rooms =
            {
                //Place a variety of room descriptions here
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
            //Generate a Random object and get a random room description
            Random rand = new Random();
            //since the max value in the Next() is exclusive, we can just use the .Length property to include all indexes from our array.
            int indexNbr = rand.Next(rooms.Length);
            string room = "**** NEW ROOM ****\n" + rooms[indexNbr] + "\n";
            //Return room
            return room;
        }
    }
}
