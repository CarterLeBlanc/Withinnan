using System;
using System.Collections.Generic;
using System.Text;

namespace Withinnan
{
    class PathTwoEnd
    {
        private string _choice = "";
        private bool _exit = false;

        public void Main()
        {
            Console.WriteLine("You enter the room and the door shuts behind you.");
            Console.ReadKey();
            Console.WriteLine("The only thing inside this room is a large decorated mirror.");
            Console.ReadKey();
            Console.WriteLine("You see yourself in the mirror, but something looks off.");
            Console.ReadKey();
            Console.WriteLine("The eyes are completely black and there's an overall sinister feeling in the air.");
            Console.ReadKey();
            Console.WriteLine("As you lean in to take a closer look the reflection reaches out and grabs you.");
            Console.ReadKey();
            Console.WriteLine("You manage to break out of it's grasp, but now it's stepping out of the mirror to go after you.");

            while (!_exit)
            {
                Console.WriteLine("How do you respond?");
                Console.WriteLine("1: Fight the reflection.");
                Console.WriteLine("2: Run out of the room and shut the door.");
                Console.WriteLine("3: Reason with the reflection.");

                _choice = Console.ReadLine();
                CheckDecision(_choice);
            }
        }

        public void CheckDecision(string choice)
        {
            if (choice == "1")
            {
                Console.WriteLine("You try to fight it, but you're both evenly matched in strength and ability.");
                Console.ReadKey();
                Console.WriteLine("This seems futile. Another approach is required.");
                Console.ReadKey();
                Console.Clear();
            }

            else if (choice == "2")
            {
                Console.WriteLine("You run for the door yelling the password, but the door won't open.");
                Console.ReadKey();
                Console.WriteLine("The reflection begins to speak. 'You can't run from me. I'll always be there.'");
                Console.ReadKey();
                Console.WriteLine("You can't escape. Try doing something else.");
                Console.ReadKey();
                Console.Clear();
            }

            else if (choice == "3")
            {
                Console.WriteLine("You decide to try reasoning with it: 'What are you? What do you want?'");
                Console.ReadKey();
                Console.WriteLine("The reflection responds: 'I am a part of you. The other side of yourself that you hate to see.\n You need me, and I need you. Why won't you accept me?'");
                Console.ReadKey();
                Console.WriteLine("You answer: 'Why should I? All you do is cause trouble. I wish I could be rid of you.'");
                Console.ReadKey();
                Console.WriteLine("The reflection speaks: 'Everyone has a dark side. A piece of them just like me.\n There can be no light without dark. And so your good side can not exist without me.'");
                Console.ReadKey();
                Console.WriteLine("The reflection extends its hand: 'Enough fighting. We need each other.\n You can accept this truth, can't you? It's what makes you human.'");
                Console.ReadKey();
                Console.WriteLine("You reach out to take the reflection's hand.\n The two of you merge together into one as the surrounding area begins to disappear.");
                Console.ReadKey();
                Console.WriteLine("You feel at peace. As though everythings is finally as it should be. Everything has gone dark and quiet.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Game Over");
                Console.ReadKey();
                _exit = true;
            }
        }
    }
}
