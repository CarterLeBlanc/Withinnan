using System;
using System.Collections.Generic;
using System.Text;

namespace Withinnan
{
    class StartingRoom
    {
        private string _choice = "";
        private bool _exit = false;

        public void Main()
        {
            Console.WriteLine("You open your eyes. The room is dark and appears to be mostly empty.");
            Console.ReadKey();
            Console.WriteLine("Everything feels so familiar, yet so strange at the same time.");
            Console.ReadKey();
            Console.WriteLine("On the wall to your left you can see a simple BLACK door. The color is faded and it seems to be worn out.");
            Console.ReadKey();
            Console.WriteLine("On the wall to your right is an elaborately decorated door. It is BLUE with an intricate silver design. It looks almost as if it's never been touched.");
            Console.ReadKey();
            Console.Clear();

            while (!_exit)
            {
                Console.WriteLine("Which door would you like to open?");
                Console.WriteLine("1: BLACK");
                Console.WriteLine("2: BLUE");

                _choice = Console.ReadLine();
                CheckDecision(_choice);
            }
        }

        public void CheckDecision(string choice)
        {
            //Choose a path based on the player's decision
            if (choice == "1")
            {
                Console.Clear();

                PathOneStart pathOne = new PathOneStart();
                pathOne.Main();

                _exit = true;
            }

            if (choice == "2")
            {
                Console.Clear();

                PathTwoStart pathTwo = new PathTwoStart();
                pathTwo.Main();

                _exit = true;
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
