using System;

namespace PokemonTraining2
{
    internal class Program
    {
        public static void Train2(string[] args)
        {
            // === 第二章：判斷與決策 (Logic & Decisions) ===
            // 目標：學會使用 If/Else 來做決定

            int safariBalls = 5;
            string wildPokemon = "Pikachu";
            int catchRate = 60; // 捕捉率 60%

            Console.WriteLine($"A wild {wildPokemon} appeared!");
            Console.WriteLine("What will you do? (1: Throw a ball, 2: Run)");

            string choice = Console.ReadLine();

            // 1. 基礎判斷 (If/Else)
            if (choice == "1")
            {
                safariBalls = safariBalls - 1;
                Console.WriteLine($"You threw a ball! Remaining balls: {safariBalls}");

                // 模擬一個亂數 (0~100)
                Random rng = new Random();
                int luck = rng.Next(0, 100);

                // 2. 巢狀判斷 (判斷裡面還有判斷)
                if (luck < catchRate)
                {
                    Console.WriteLine("Congratulations! Capture successful!");
                }
                else
                {
                    Console.WriteLine("Oh no! It ran away!");
                }
            }
            else if (choice == "2") // 多重條件
            {
                Console.WriteLine("You turned and ran away.");
            }
            else
            {
                Console.WriteLine("Invalid command, Pikachu stares at you.");
            }
        }
    }
}