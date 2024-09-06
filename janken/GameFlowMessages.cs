namespace janken
{
    internal static class GameFlowMessages
    {
        public const string GameStart = "ジャンケンをします";
        public const string InputPrompt = "グー: 1, チョキ: 2, パー: 3 のいずれかを入力しエンターキーを押してください";
        public const string InvalidInput = "無効な入力です。エンターを押して終了してください";
        public const string YourHand = "あなたは";
        public const string OpponentHand = "相手の手は: ";
        public const string PressEnter = "エンターキーを押して次へ進む";
        public const string Janken = "ジャンケンポイ！";
        public const string DrawMessage = "引き分けです。もう一度ジャンケンをします。";
        public const string EndMessage = "終了するにはエンターキーを押してください...";
    }
}
