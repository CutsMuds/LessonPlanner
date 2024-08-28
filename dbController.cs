using Microsoft.Data.Sqlite;
using System;

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
        public static bool checkForSchedulePreset(string name)
        {
            SqliteCommand command = new SqliteCommand($"SELECT * FROM schedulePresets WHERE name=\"{name}\"", db);

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
        public static void createSchedulePreset(string name)
        {
            SqliteCommand command = new SqliteCommand($"INSERT INTO schedulePresets (key,name,tasks) VALUES ({getMaxSchedulePresetKey() + 1},\"{name}\",\"\")", db);
            command.ExecuteNonQuery();
        }
        public static int getMaxSchedulePresetKey()
        {
            SqliteCommand command = new SqliteCommand("SELECT MAX(key) FROM schedulePresets", db);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader.GetInt32(0);
                }
                return -1;
            }
        }
    }
}