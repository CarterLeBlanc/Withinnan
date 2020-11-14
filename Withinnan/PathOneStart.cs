using System;
using System.Collections.Generic;
using System.Text;

namespace Withinnan
{
    class PathOneStart
    {
        private string _choice = "";
        private bool _exit = false;

        PlayerStats player = new PlayerStats();
        PathOneEnd path = new PathOneEnd();

        public void Main()
        {
            Console.WriteLine("You enter a messy room. There are tables overturned, and the walls and floor are marred by what appear to be large claw marks.");
            Console.ReadKey();
            Console.WriteLine("You also notice a rather sizable chest. It is wrapped in chains that are held together with a rusty padlock.");
            Console.ReadKey();
            Console.Clear();

            while (!_exit)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: Attempt to pry open the chest.");
                Console.WriteLine("2: Attempt to pick the lock.");
                Console.WriteLine("3: Search for a key.");

                _choice = Console.ReadLine();
                CheckDecision(_choice);
            }
        }

        public void CheckDecision(string choice)
        {
            //Perform a stat check based on the player's decision
            if (choice == "1")
            {
                Console.Clear();

                player.CheckStrength();

                if (player.GetPassCheck() == true)
                {
                    Console.WriteLine("You pull and pull. Somehow you manage to break the old rusted padlock, allowing you to open the chest.");
                    Console.ReadKey();
                    Console.Clear();
                    path.Main();
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("You pull, but the chains are just too secure.");
                    Console.ReadKey();
                    Console.WriteLine("You can try forcing again, or perhaps there's another way.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            if (choice == "2")
            {
                Console.Clear();

                player.CheckIntelligence();

                if (player.GetPassCheck() == true)
                {
                    Console.WriteLine("After messing with the lock for a bit you hear a click as the padlock opens. You move the chains and open the chest.");
                    Console.ReadKey();
                    Console.Clear();
                    path.Main();
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("You attempt to pick the lock, but you can't seem to get it.");
                    Console.ReadKey();
                    Console.WriteLine("One more try might open it, or there may be another way through.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            if (choice == "3")
            {
                Console.Clear();

                player.CheckCharisma();

                if (player.GetPassCheck() == true)
                {
                    Console.WriteLine("After thoroughly searching the room you find a key that perfectly matches the lock. You move the chains to the side and open the chest.");
                    Console.ReadKey();
                    Console.Clear();
                    path.Main();
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("You search the room for a key, but you don't see anything.");
                    Console.ReadKey();
                    Console.WriteLine("There must be a key somewhere around here. You can search again, or try another approach.");
                    Console.Clear();
                }
            }

            //Ask the question again if a valid answer is not chosen
            else if (choice != "1" && choice != "2" && choice != "3")
            {
                Console.Clear();
                _choice = "";
                Console.WriteLine("Please select a valid choice.");
                Console.ReadKey();
                return;
            }
        }
    }
}
