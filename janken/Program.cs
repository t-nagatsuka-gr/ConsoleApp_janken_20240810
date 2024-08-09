using System;
using System.Threading;

namespace janken
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ジャンケンをします");
            Console.WriteLine("グー: 0, チョキ: 1, パー: 2 のいずれかを入力しエンターキーを押してください");

            // 入力した手をhandに代入
            string hand = Console.ReadLine();

            int playerHand;
            if (!int.TryParse(hand, out playerHand) || playerHand < 0 || playerHand > 2)
            {
                Console.WriteLine("無効な入力です。エンターを押して終了してください");
                Console.ReadLine();
                return;
            }

            // プレイヤーが選んだ手を表示
            Console.WriteLine($"あなたは{GetHand(playerHand)}を選択しました");
            // 処理を一秒待つ
            Thread.Sleep(1000);
            Console.WriteLine("エンターキーを押して次へ進む");
            Console.ReadLine();

            Console.WriteLine("ジャンケンポイ！");
            // 処理を一秒待つ
            Thread.Sleep(1000);
            Console.WriteLine("エンターキーを押して次へ進む");
            Console.ReadLine();

            // CPUの手をランダムに決める
            Random random = new Random();
            int cpuHand = random.Next(0, 3);

            Console.WriteLine($"相手の手は: {GetHand(cpuHand)}");
            // 処理を一秒待つ
            Thread.Sleep(1000);
            string result = GameResult(playerHand, cpuHand);
            Console.WriteLine(result);

            // ここでエンターキーが押されるまで待つ
            Console.WriteLine("終了するにはエンターキーを押してください...");
            Console.ReadLine();
        }

        static string GetHand(int hand)
        {
            switch (hand)
            {
                case 0: return "グー";
                case 1: return "チョキ";
                case 2: return "パー";
                default: return "無効な手";
            }
        }

        static string GameResult(int player, int cpu)
        {
            if (player == cpu)
            {
                return "引き分け";
            }
            if ((player == 0 && cpu == 1) || (player == 1 && cpu == 2) || (player == 2 && cpu == 0))
            {
                return "あなたの勝ち";
            }
            else
            {
                return "あなたの負け";
            }
        }
    }
}
