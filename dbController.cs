using Microsoft.Data.Sqlite;

namespace LessonPlanner
{
    public static class dbController
    {
        private static SqliteConnection db;
        public static void init()
        {
            db = new SqliteConnection("Data Source=db.db");
            db.Open();
        }
        public static List<schedulePreset> getSchedulePresets()
        {
            SqliteCommand сommand = new SqliteCommand("SELECT * FROM schedulePresets", db);
            List<schedulePreset> toReturn = new List<schedulePreset>();

            using (SqliteDataReader reader = сommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        toReturn.Add(new schedulePreset(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }
                }
            }
            return toReturn;
        }
    }
}
