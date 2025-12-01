using System;

namespace PokemonTraining4
{
    internal class Program
    {
        public static void Train4(string[] args)
        {
            // === 第四章：函式 (Methods) ===
            // 目標：將重複的邏輯打包成「技能」

            // 呼叫函式 1: 簡單動作
            ShowWelcomeMessage();

            int myBalls = 5;

            // 呼叫函式 2: 傳入參數並取得結果
            // 我們把「計算捕捉是否成功」這件事交給專業的函式去做
            bool isCauthed =false;
            while (myBalls > 0)
            {
                bool result = TryCatch("Pikachu", 50);

                if (result)
                {
                    Console.WriteLine("Main received notification: caught it!");
                    return;
                }
                Console.WriteLine("Main received notification: failed.");

                Console.ReadLine();
                myBalls--;
            }
        }

        // --- 定義函式區域 ---

        // 1. void: 不回傳資料，只執行動作
        static void ShowWelcomeMessage()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("* Welcome to the Poké Ball Throwing System *");
            Console.WriteLine("***************************");
        }

        // 2. bool: 會回傳真假值 (參數：名字，難度)
        static bool TryCatch(string name, int difficulty)
        {
            Console.WriteLine($"Attempting to catch {name}...");

            Random rng = new Random();
            int luck = rng.Next(0, 100);

            if (luck > difficulty)
            {
                return true; // 回傳成功
            }
            return false; // 回傳失敗
            
        }
    }
}