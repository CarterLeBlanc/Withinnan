using System;
using System.Collections.Generic;
using System.Text;

namespace Withinnan
{
    class PathTwoStart
    {
        private string _answer = "";
        private string _choice = "";
        private bool _exit = false;

        PlayerStats player = new PlayerStats();
        PathTwoEnd path = new PathTwoEnd();

        public void Main()
        {
            Console.WriteLine("You enter the room to see a large locked door with a robed man standing beside it.");
            Console.ReadKey();
            Console.WriteLine("The man opens his mouth and says 'In order to get through this door you must solve a riddle.'");
            Console.ReadKey();
            Console.WriteLine("'I get cut but I never bleed\n I have teeth but I don't bite\n I get turned but I am not a page'");
            Console.WriteLine("What am I?");
            Console.ReadKey();

            while (!_exit)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: Answer the riddle.");
                Console.WriteLine("2: Try to convince the robed man to give you the answer.");
                Console.WriteLine("3: Threaten the man until he gives you the answer.");

                _choice = Console.ReadLine();
                CheckDecision(_choice);
            }
        }

        public void CheckDecision(string choice)
        {
            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("What is the answer? (Answer is one word)");
                _answer = Console.ReadLine().ToUpper();

                if (_answer == "KEY")
                {
                    Console.Clear();
                    Console.WriteLine("'Very good' says the robed stranger.");
                    Console.ReadKey();
                    Console.WriteLine("The door creaks open, revealing the next room.");
                    Console.ReadKey();
                    Console.Clear();
                    path.Main();
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("The man says 'I'm afraid that isn't it. Try again.'");
                    Console.ReadKey();
                }
            }

            else if (choice == "2")
            {
                Console.Clear();

                player.CheckCharisma();

                if (player.GetPassCheck() == true)
                {
                    Console.WriteLine("You make a convincing plea and the robed man decides to help you. 'Key' he says, and the door opens.");
                    Console.ReadKey();
                    Console.Clear();
                    path.Main();
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("The robed stranger doesn't seem compelled to help you.");
                    Console.ReadKey();
                    Console.WriteLine("Looks like you're on your own. Maybe you should try something else.");
                    Console.Clear();
                }
            }

            else if (choice == "3")
            {
                Console.Clear();

                player.CheckStrength();

                if (player.GetPassCheck() == true)
                {
                    Console.WriteLine("You intimidate the stranger into helping you.");
                    Console.ReadKey();
                    Console.WriteLine("'K-k-key' he says in a shaky voice. The door suddenly opens.");
                    Console.Clear();
                    path.Main();
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("'How pitiful. Why don't you try using your own brain instead of mine?' says the stranger.");
                    Console.ReadKey();
                    Console.WriteLine("He doesn't seem intimidated. Time for a different approach.");
                    Console.Clear();
                }
            }
        }
    }
}
