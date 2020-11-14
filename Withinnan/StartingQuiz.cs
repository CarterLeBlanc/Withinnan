using System;
using System.Collections.Generic;
using System.Text;

namespace Withinnan
{
    class StartingQuiz
    {
        private string _answer = "";
        private bool _exit = false;

        PlayerStats player = new PlayerStats();

        public void Quiz()
        {
            //Loop question until valid answer is given
            while (!_exit)
            {
                //Ask question
                Console.WriteLine("Which of these is the most important to you?");
                Console.WriteLine("1: Power");
                Console.WriteLine("2: Knowledge");
                Console.WriteLine("3: Friendship");

                //Set the answer to be whatever the user types
                _answer = Console.ReadLine();

                //Check to see if the answer is a valid choice
                CheckAnswers(_answer);
                Console.Clear();
            }

            //Reset _exit and _answer
            _exit = false;
            _answer = "";

            //Loop question until valid answer is given
            while (!_exit)
            {
                //Ask question
                Console.WriteLine("How do you prefer to handle a conflict?");
                Console.WriteLine("1: I fight my way out.");
                Console.WriteLine("2: I try to out smart my opponent.");
                Console.WriteLine("3: I try to come up with a solution that makes both sides happy.");

                //Set the answer to be whatever the user types
                _answer = Console.ReadLine();

                //Check to see if the answer is a valid choice
                CheckAnswers(_answer);
                Console.Clear();
            }

            //Reset _exit and _answer
            _exit = false;
            _answer = "";

            //Loop question until valid answer is given
            while (!_exit)
            {
                //Ask question
                Console.WriteLine("What is your favorite thing to do in your free time?");
                Console.WriteLine("1: Exercise.");
                Console.WriteLine("2: Research things I'm interested in.");
                Console.WriteLine("3: Hang out with friends.");

                //Set the answer to be whatever the user types
                _answer = Console.ReadLine();

                //Check to see if the answer is a valid choice
                CheckAnswers(_answer);
                Console.Clear();
            }

            //Reset _exit and _answer
            _exit = false;
            _answer = "";

            //Loop question until valid answer is given
            while (!_exit)
            {
                //Ask question
                Console.WriteLine("What is your favorite thing to do in your free time?");
                Console.WriteLine("1: Exercise.");
                Console.WriteLine("2: Research things I'm interested in.");
                Console.WriteLine("3: Hang out with friends.");

                //Set the answer to be whatever the user types
                _answer = Console.ReadLine();

                //Check to see if the answer is a valid choice
                CheckAnswers(_answer);
                Console.Clear();
            }

            //Reset _exit and _answer
            _exit = false;
            _answer = "";
        }

        public void CheckAnswers(string answer)
        {
            //Adjust player stats based on chosen answer
            if (answer == "A")
            {
                player.SetStrength(30);
                _exit = true;
            }

            if (answer == "B")
            {
                player.SetIntelligence(30);
                _exit = true;
            }

            if (answer == "C")
            {
                player.SetCharisma(30);
                _exit = true;
            }

            //Ask the question again if a valid answer is not chosen
            else if (answer != "A" && answer != "B" && answer != "C")
            {
                _answer = "";
                Console.WriteLine("Please select a valid choice.");
                Console.ReadKey();
                return;
            }
        }
    }
}
