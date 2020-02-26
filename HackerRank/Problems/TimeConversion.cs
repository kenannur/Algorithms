namespace HackerRank.Problems
{
    public static class TimeConversion
    {
        public static string Solve(string s)
        {
            var hourFormat = s.Substring(8, 2);
            var hour = s.Substring(0, 2);

            if(hourFormat == "PM")
            {
                if(hour == "12")
                {
                    return s.Substring(0, 8);
                }
                var hourInt = int.Parse(hour);
                hourInt += 12;
                var hourStr = hourInt.ToString();
                return $"{hourStr}{s.Substring(2, 6)}";
            }
            else
            {
                if (hour == "12")
                {
                    return $"00{s.Substring(2, 6)}";
                }
                return s.Substring(0, 8);
            }
        }
    }
}
