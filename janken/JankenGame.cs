using System;
using System.Threading;

namespace janken
{
    internal static class JankenGame
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine(GameFlowMessages.GameStart);
                Console.WriteLine(GameFlowMessages.InputPrompt);

                string handInput = Console.ReadLine();
                int playerHand;
                if (!int.TryParse(handInput, out playerHand) || playerHand < 1 || playerHand > 3)
                {
                    Console.WriteLine(GameFlowMessages.InvalidInput);
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine($"{GameFlowMessages.YourHand}{HandConverter.GetHandName(playerHand)}");
                Thread.Sleep(1000);
                Console.WriteLine(GameFlowMessages.PressEnter);
                Console.ReadLine();

                Console.WriteLine(GameFlowMessages.Janken);
                Thread.Sleep(1000);
                Console.WriteLine(GameFlowMessages.PressEnter);
                Console.ReadLine();

                Random random = new Random();
                int cpuHand = random.Next(1, 4);

                Console.WriteLine($"{GameFlowMessages.OpponentHand}{HandConverter.GetHandName(cpuHand)}");
                Thread.Sleep(1000);
                string result = GameResult.DetermineResult(playerHand, cpuHand);
                Console.WriteLine(result);

                if (result == "引き分け")
                {
                    Console.WriteLine(GameFlowMessages.DrawMessage);
                    Thread.Sleep(1000);
                    continue; // 引き分けの場合、ループの最初から再度ジャンケンを行う
                }
                break;
            }

            Console.WriteLine(GameFlowMessages.EndMessage);
        }
    }
}

