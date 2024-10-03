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
                // ゲーム開始
                Console.WriteLine(GameFlowMessages.GameStart);

                int playerHand;

                while (true) // ユーザーの入力を繰り返し求めるループ
                {
                    Console.WriteLine(GameFlowMessages.InputPrompt);

                    // ユーザーからの入力したものを代入
                    string handInput = Console.ReadLine();

                    // ユーザーからの入力を整数に変換。または１～３までの入力の場合処理を行う
                    if (!int.TryParse(handInput, out playerHand) || playerHand < 1 || playerHand > 3)
                    {
                        Console.WriteLine(GameFlowMessages.InvalidInput);
                        Thread.Sleep(1000);
                        continue; // 無効な入力なので再度ループの最初に戻る
                    }
                    // 有効な入力がされた場合ループを抜ける
                    break;
                }

                // ジャンケン開始のメッセージ表示
                Console.WriteLine(GameFlowMessages.Janken);
                Thread.Sleep(1000);
                Console.WriteLine(GameFlowMessages.PressEnter);
                Console.ReadLine();

                // ユーザーが選択した手（グー、チョキ、パー）を取得し、表示する
                Console.WriteLine($"{GameFlowMessages.YourHand}{HandConverter.GetHandName(playerHand)}");
                Thread.Sleep(1000);
                Console.WriteLine(GameFlowMessages.PressEnter);
                Console.ReadLine();

                // CPUの手をランダムに決定し表示する
                Random random = new Random();
                int cpuHand = random.Next(1, 4);
                Console.WriteLine($"{GameFlowMessages.OpponentHand}{HandConverter.GetHandName(cpuHand)}");
                Thread.Sleep(1000);

                // メソッドを呼び出しユーザー、CPUの手を引数として渡し勝敗を判定する
                string result = GameResult.DetermineResult(playerHand, cpuHand);
                Console.WriteLine(result);

                // 引き分けの場合、ループの最初から再度ジャンケンを行う
                if (result == "引き分け")
                {
                    Console.WriteLine(GameFlowMessages.DrawMessage);
                    Thread.Sleep(1000);
                    continue; 
                }
                break;
            }
            Console.WriteLine(GameFlowMessages.EndMessage);
        }
    }
}

