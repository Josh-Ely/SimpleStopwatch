using System.Data;
using System.Data.SQLite;

namespace SimpleStopwatch.Data
{
    public class DatabaseHelper
    {
        /// <summary>
        /// creates the .sqlite file and TimeLogs table
        /// </summary>
        /// <param name="dbPath"></param>
        /// <returns></returns>
        public static async Task InitializeDatabase(string dbPath)
        {
            using var conn = new SQLiteConnection($"Data Source={dbPath}");
            conn.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS TimeLogs (Id INTEGER PRIMARY KEY AUTOINCREMENT, ElapsedSeconds REAL, ElapsedFormatted TEXT, SavedAt TEXT)";

            using var cmd = new SQLiteCommand(sql, conn);
            await cmd.ExecuteNonQueryAsync();
        }

        /// <summary>
        /// inserts a new time log 
        /// </summary>
        /// <param name="timeLog"></param>
        /// <param name="dbPath"></param>
        /// <returns></returns>
        public static async Task Insert(TimeLog timeLog, string dbPath)
        {
            using var conn = new SQLiteConnection($"Data Source={dbPath}");
            conn.Open();

            string sql = @"INSERT INTO TimeLogs (ElapsedSeconds, ElapsedFormatted, SavedAt) VALUES (@ElapsedSeconds, @ElapsedFormatted, @SavedAt)";

            using var cmd = new SQLiteCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ElapsedSeconds", timeLog.ElapsedSeconds);
            cmd.Parameters.AddWithValue("@ElapsedFormatted", timeLog.ElapsedFormatted);
            cmd.Parameters.AddWithValue("@SavedAt", timeLog.SavedAt);

            await cmd.ExecuteNonQueryAsync();
        }

        /// <summary>
        /// returns a list of time logs
        /// </summary>
        /// <param name="dbPath"></param>
        /// <returns></returns>
        public static List<TimeLog> GetTimeLogs(string dbPath)
        {
            string sql = "SELECT * FROM TimeLogs ORDER BY SavedAt DESC";

            using var conn = new SQLiteConnection($"Data Source={dbPath}");
            conn.Open();

            using var cmd = new SQLiteCommand(sql, conn);

            using var adapter = new SQLiteDataAdapter(cmd);

            DataTable dt = new();
            adapter.Fill(dt);

            List<TimeLog> timeLogs = [];

            // loops through each row in the data table
            foreach (DataRow row in dt.Rows)
            {
                // gets values from the row
                int id = Convert.ToInt32(row["Id"]);
                double elapsedSeconds = Convert.ToDouble(row["ElapsedSeconds"]);
                string? elapsedFormatted = row["ElapsedFormatted"].ToString();
                string? savedAt = row["SavedAt"].ToString();

                // creates a new time log
                TimeLog timeLog = new()
                {
                    Id = id,
                    ElapsedFormatted = elapsedFormatted!,
                    ElapsedSeconds = elapsedSeconds,
                    SavedAt = savedAt!,
                };

                // adds the time log to the list
                timeLogs.Add(timeLog);
            }

            // returns the list of time logs
            return timeLogs;
        }

        /// <summary>
        /// deletes all time logs
        /// </summary>
        /// <param name="dbPath"></param>
        /// <returns></returns>
        public static async Task DeleteAllTimeLogs(string dbPath)
        {
            string sql = @"DELETE FROM TimeLogs";

            using var conn = new SQLiteConnection($"Data Source={dbPath}");
            conn.Open();

            using var cmd = new SQLiteCommand(sql, conn);
            await cmd.ExecuteNonQueryAsync();
        }

        /// <summary>
        /// deletes a time log based on the id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dbPath"></param>
        /// <returns></returns>
        public static async Task DeleteTimeLog(int id, string dbPath)
        {
            string sql = @"DELETE FROM TimeLogs WHERE Id = @Id";

            using var conn = new SQLiteConnection($"Data Source={dbPath}");
            conn.Open();

            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            await cmd.ExecuteNonQueryAsync();
        }

        /// <summary>
        /// updates a time log by the id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedTimeSpan"></param>
        /// <param name="dbPath"></param>
        /// <returns></returns>
        public static async Task UpdateTimeLog(int id, TimeSpan updatedTimeSpan, string dbPath)
        {
            string elapsedFormatted = TimeLog.FormatTimeSpan(updatedTimeSpan);
            double elapsedSeconds = updatedTimeSpan.TotalSeconds;

            string sql = @"UPDATE TimeLogs SET ElapsedFormatted = @Formatted, ElapsedSeconds = @Seconds WHERE Id = @Id";

            using var conn = new SQLiteConnection($"Data Source={dbPath}");
            conn.Open();

            using var cmd = new SQLiteCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Seconds", elapsedSeconds);
            cmd.Parameters.AddWithValue("@Formatted", elapsedFormatted);
            cmd.Parameters.AddWithValue("@Id", id);

            await cmd.ExecuteNonQueryAsync();
        }
    }
}
