using System;

namespace PokemonTraining3
{
    internal class Program
    {
        public static void Train3(string[] args)
        {
            // === 第三章：迴圈 (Loops) ===
            // 目標：學會使用 While 或 For 來重複執行動作

            int safariBalls = 5;

            Console.WriteLine("=== Start hunting (until balls run out) ===");

            // 1. While 迴圈：只要條件成立 (球大於0)，就一直執行
            while (safariBalls > 0)
            {
                Console.WriteLine($"\nCurrent balls: {safariBalls}");
                Console.WriteLine("A wild Pokémon appears! Throw a ball? (y/n)");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    safariBalls--; // 這是 safariBalls = safariBalls - 1 的縮寫
                    Console.WriteLine("Ball thrown!");
                }
                else
                {
                    Console.WriteLine("You decided to save the ball.");
                }

                // 2. Break (中斷)：特殊情況強制離開迴圈
                if (safariBalls == 1)
                {
                    Console.WriteLine("Warning: this is your last ball! (System reserves it, ending hunt)");
                    break; // 直接跳出 while
                }
            }

            Console.WriteLine("\nGame over!");
        }
    }
}