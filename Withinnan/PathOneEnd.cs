using System;
using System.Collections.Generic;
using System.Text;

namespace Withinnan
{
    class PathOneEnd
    {
        private string _choice = "";
        private bool _exit = false;

        PlayerStats player = new PlayerStats();

        public void Main()
        {
            Console.WriteLine("As you peer inside the chest you see that instead of treasure there is a ladder leading into a lower floor.");
            Console.ReadKey();
            Console.WriteLine("You climb down and enter a small room with only a single torch lighting the area.");
            Console.ReadKey();
            Console.WriteLine("In the corner of the room you see a large beast crouching. It has huge claws and dark fur covering its massive body.");
            Console.ReadKey();
            Console.WriteLine("Upon closer inspection you notice large gashes covering it, still bleeding. The wounds look pretty deep.");
            Console.ReadKey();
            Console.WriteLine("The beast begins snarling at you. It bares it's teeth as if preparing to attack.");
            Console.ReadKey();
            Console.WriteLine("It sounds strange, but you swear that you can see what appears to be fear in its eyes.\nIt almost seems to be afraid of you even though it's twice your size.");
            Console.ReadKey();
            Console.Clear();

            while (!_exit)
            {
                Console.WriteLine("What will you do?");
                Console.WriteLine("1: Fight the beast.");
                Console.WriteLine("2: Climb back up the ladder and seal the chest.");
                Console.WriteLine("3: Comfort the beast.");

                _choice = Console.ReadLine();
                CheckDecision(_choice);
            }
        }

        public void CheckDecision(string choice)
        {
            if (choice == "1")
            {
                Console.WriteLine("You lunge at the beast and the beast fights back.");
                Console.ReadKey();
                Console.WriteLine("You wrestle with the creature for a while, but it ultimately over powers you.\nNo matter how hard you fight you can't escape its grasp.");
                Console.WriteLine("The beast ruthlessly bites into your throat, killing you.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Game Over");
                Console.ReadKey();
                _exit = true;
            }

            if (choice == "2")
            {
                Console.WriteLine("You turn and run for the ladder, climbing it as fast as possible.");
                Console.ReadKey();
                Console.WriteLine("You manage to shut the chest, but you can't escape the feeling that the beast won't be held there for long.");
                Console.ReadKey();
                Console.WriteLine("You got away with your life, but you are forever haunted by what you saw.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Game Over");
                Console.ReadKey();
                _exit = true;
            }

            if (choice == "3")
            {
                Console.WriteLine("You slowly approach the beast with you arms outstretched. It begins growling.");
                Console.ReadKey();
                Console.WriteLine("You manage to get close enough to the beast and wrap your arms around it.");
                Console.ReadKey();
                Console.WriteLine("It bites into your shoulder in response, but then lets go for some reason. Perhaps it can sense your intention?");
                Console.ReadKey();
                Console.WriteLine("You jump back from the pain and fall on the floor. \nAs you look back up at the beast you notice that it's eyes appear to be tearing up.");
                Console.ReadKey();
                Console.WriteLine("You watch in shock as the beast changes form. It morphs into a human shape.");
                Console.ReadKey();
                Console.WriteLine("Wait, not just any human shape. It looks just like you!");
                Console.ReadKey();
                Console.WriteLine("It helps you back onto your feet. You look into its eyes and it says 'Thank you' before fading away.");
                Console.ReadKey();
                Console.WriteLine("You're not sure what exactly happened, but you feel relieved. It's as if a weight was lifted from you.");
                Console.ReadKey();
                Console.WriteLine("You close your eyes as the world around you fades away. Everything is quiet and peaceful.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Game Over");
                Console.ReadKey();
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
