using System;

namespace Withinnan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("____    __    ____  __  .___________. __    __   __  .__   __. .__   __.      ___      .__   __.");
            Console.WriteLine("|   |  |  |  /   / |  | |           ||  |  |  | |  | |  | |  | |  | |  |     /   |     |  | |  |");
            Console.WriteLine(" |   ||    |/   /  |  | `---|  |----`|  |__|  | |  | |   ||  | |   ||  |    /  ^  |    |   ||  |");
            Console.WriteLine("  |            /   |  |     |  |     |   __   | |  | |  . `  | |  . `  |   /  |_|  |   |  . `  |");
            Console.WriteLine("   |    ||    /    |  |     |  |     |  |  |  | |  | |  ||   | |  ||   |  /  _____  |  |  ||   |");
            Console.WriteLine("    |__|  |__/     |__|     |__|     |__|  |__| |__| |__| |__| |__| |__| /__|     |__| |__| |__|");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Before we start I need you to answer a few questions.");
            Console.ReadKey();
            Console.Clear();

            //Starting quiz
            StartingQuiz quiz = new StartingQuiz();
            quiz.Main();

            Console.WriteLine("Now that we're done with that, shall we begin?");
            Console.ReadKey();
            Console.Clear();

            //Starting room
            StartingRoom room = new StartingRoom();
            room.Main();
        }
    }
}
