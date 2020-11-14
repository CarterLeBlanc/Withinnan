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
            Console.WriteLine("On the wall to your left you can see a simple BLACK door. The color is faded and it seems to be worn out.");
            Console.ReadKey();
            Console.WriteLine("On the wall to your right is an elaborately decorated door. It is RED with an intricate gold design. It looks almost as if it's never been touched.");
            Console.ReadKey();
            Console.WriteLine("Directly in front of you is another door. It's a dark shade of BLUE. The door's design is nothing special, but it still looks significantly better than the BLACK door.");
            Console.ReadKey();
            Console.Clear();

            while (!_exit)
            {
                Console.WriteLine("Which door would you like to open?");
                Console.WriteLine("1: BLACK");
                Console.WriteLine("2: RED");
                Console.WriteLine("3: BLUE");

                _choice = Console.ReadLine();
                CheckDecision(_choice);
            }
        }

        public void CheckDecision(string choice)
        {
            //Adjust player stats based on chosen answer
            if (choice == "1")
            {
                PathOneStart pathOne = new PathOneStart();
                pathOne.Main();
                _exit = true;
            }

            if (choice == "2")
            {
                PathTwoStart pathTwo = new PathTwoStart();
                pathTwo.Main();
                _exit = true;
            }

            if (choice == "3")
            {
                PathThreeStart pathThree = new PathThreeStart();
                pathThree.Main();
                _exit = true;
            }

            //Ask the question again if a valid answer is not chosen
            else if (choice != "1" && choice != "2" && choice != "3")
            {
                _choice = "";
                Console.WriteLine("Please select a valid choice.");
                Console.ReadKey();
                return;
            }
        }
    }
}
