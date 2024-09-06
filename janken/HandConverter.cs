namespace janken
{
    internal static class HandConverter
    {
        public static string GetHandName(int hand)
        {
            switch (hand)
            {
                case 1: return "グー";
                case 2: return "チョキ";
                case 3: return "パー";
                default: return "無効な手";
            }
        }
    }
}
