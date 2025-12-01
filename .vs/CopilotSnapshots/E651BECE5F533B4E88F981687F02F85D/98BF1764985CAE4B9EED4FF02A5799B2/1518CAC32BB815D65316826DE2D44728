using System;

namespace PokemonTrainingLauncher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a chapter to run (1-5), or enter q to quit:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PokemonTraining1.Program.Train1(args);
                    break;
                case "2":
                    PokemonTraining2.Program.Train2(args);
                    break;
                case "3":
                    PokemonTraining3.Program.Train3(args);
                    break;
                case "4":
                    PokemonTraining4.Program.Train4(args);
                    break;
                case "5":
                    PokemonTraining5.Program.Train5(args);
                    break;
                case "q":
                case "Q":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please restart and enter a number from 1 to 5.");
                    break;
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
