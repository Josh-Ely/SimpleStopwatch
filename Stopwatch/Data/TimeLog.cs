namespace SimpleStopwatch.Data
{
    public class TimeLog
    {
        public int Id { get; set; }
        public double ElapsedSeconds { get; set; }
        public required string ElapsedFormatted { get; set; }
        public required string SavedAt { get; set; }

        public static string FormatTimeSpan(TimeSpan timeSpan)
        {
            if (timeSpan.TotalMinutes < 1)
            {
                return $"{timeSpan.Seconds:D2}s";
            }
            else if (timeSpan.TotalHours < 1)
            {
                return $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
            }
            else
            {
                int totalHours = (int)timeSpan.TotalHours;
                return $"{totalHours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
            }
        }
    }
}
