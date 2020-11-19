/*Credit to Alex Sperry for helping me, and the Programmingisfun.com website, as well as reading the Canvas examples.
*/
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

namespace Trivia
{
    class StudyGame
    {
        string gameName = "Leo's Study Guide";
            public StudyGame()
        {
            Title = gameName;
            string PlayerName = "John Doe";

            WriteLine("Welcome to the study guide!");
            PlayerName = Console.ReadLine();

            WriteLine("Hello, " + PlayerName);
            WriteLine("Press enter to continue...");

            Start();
        }

        private void Start()
        {
            string input = "";
            input = Console.ReadLine();
            input = "".ToLower();
            Console.WriteLine("Type Your Answer and Hit Enter!");
            string Answer = "Placeholder";
            //Crow Question 1
            Console.WriteLine("Question 1.");
            Console.WriteLine("What is a group of crows called?");
            Answer = Console.ReadLine();
            Console.WriteLine("You wrote " + Answer + ". The correct answer was murder!");
            Console.WriteLine("Press enter to continue...");
            ReadKey();
            Clear();
            //Cat Question 2
            Console.WriteLine("Question 2.");
            Console.WriteLine("What is a group of cats called?");
            Answer = Console.ReadLine();
            Console.WriteLine("You wrote " + Answer + ". The correct answer was clowder!");
            Console.WriteLine("Press enter to continue...");
            ReadKey();
            Clear();
            //Alphabet Question 3
            Console.WriteLine("Question 3.");
            Console.WriteLine("How Many Letters Are In The Alphabet?");
            Answer = Console.ReadLine();
            Console.WriteLine("You wrote " + Answer + ". The correct answer was 26!");
            Console.WriteLine("Press enter to continue...");
            ReadKey();
            Clear();
            Console.WriteLine("Congratulations!");
        }
            
        }

    }

    class Player
    {
    int Score = 0;
    } 

    class StudyQuestion
    {
        public string question = "";
        public string answer = "";
        TriviaItem crow = TriviaItem(); 
        TriviaItem Alphabet = new TriviaItem();
        TriviaItem Cat = new TriviaItem();

    public TriviaItem Cat1 { get => Cat; set => Cat = value; }
}

    class Program
    {
        static void Main()
        {
            new StudyGame();
        }
    }
