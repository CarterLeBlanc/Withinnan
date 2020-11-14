using System;

namespace Withinnan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Withinnan");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Before we start I need you to answer a few questions.");
            Console.ReadKey();
            Console.Clear();

            //Starting quiz
            StartingQuiz quiz = new StartingQuiz();
            quiz.Quiz();
        }
    }
}
