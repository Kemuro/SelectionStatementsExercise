using System;

namespace SelectionStatementsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 11;

            Console.WriteLine();
            Console.WriteLine("Welcome contestant, enter your name to begin.");
            Console.Write("Name: ");
            string contestantName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Hello {contestantName}!");
            Console.WriteLine("Try to guess my favorite number.");
            Console.Write("Your answer: ");
            var userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userInput < favoriteNumber)
            {
                Console.WriteLine("Nope, too low!");
                Console.WriteLine("Re-enter to try again.");

            }
            else if(userInput > favoriteNumber)
            {
                Console.WriteLine("Nah, too high!");
                Console.WriteLine("Re-enter to try again.");
            }
            else
            {
                Console.WriteLine("     ಠ_ಠ");
                Console.WriteLine("... Nevermind.");
                Console.WriteLine();
                Console.WriteLine("Continue on to prize selection, lucky.");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine($"Ok {contestantName}, what is your favorite subject from the following list?");
                Console.WriteLine("(enter the letter as printed, uppercase, for your choice)");
                Console.WriteLine();
                Console.WriteLine("  M - Mathematics");
                Console.WriteLine("  S - Science");
                Console.WriteLine("  H - History");
                Console.WriteLine("  L - Language");
                Console.WriteLine("  P - Physical Education");
                Console.WriteLine();
                Console.Write("Your choice: ");

                string contestantFavSubject = Console.ReadLine();
                Console.WriteLine();

                switch (contestantFavSubject)
                {
                    case "M":
                        Console.WriteLine("Congrats, you've won a free course on Theoretical Equations!!!");
                        break;
                    case "S":
                        Console.WriteLine("Congrats, you've won a book free course on Organic Chemistry!!!");
                        break;
                    case "H":
                        Console.WriteLine("Congrats, you've won a free course on Ancient Civilizations!!!");
                        break;
                    case "L":
                        Console.WriteLine("Congrats, you've won a free course on the Spanish language!!!");
                        break;
                    case "P":
                        Console.WriteLine("Congrats, you've won a free gym membership for 6 months!!!");
                        break;
                    default:
                        Console.WriteLine("Aww too bad, the code you entered was not in accordance to the instructions.");
                        Console.WriteLine("You recieve no reward this attempt. Re-enter to try again.");
                        break;

                }

                Console.WriteLine();
                Console.WriteLine("Thanks for playing!");


            }


        }
    }
}
