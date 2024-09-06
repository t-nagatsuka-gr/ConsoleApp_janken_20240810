namespace janken
{
    internal static class GameResult
    {
        public static string DetermineResult(int playerHand, int cpuHand)
        {
            if (playerHand == cpuHand)
            {
                return "引き分け";
            }
            if ((playerHand == 1 && cpuHand == 2) || (playerHand == 2 && cpuHand == 3) || (playerHand == 3 && cpuHand == 1))
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
