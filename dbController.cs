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
        public static List<int> getAllTasksDaysInMonth(int month)
        {
            List<int> toReturn = new List<int>();
            SqliteCommand command = new SqliteCommand($"SELECT day FROM days WHERE month = {month} AND year = {DateTime.Now.Year}", db);

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        toReturn.Add(reader.GetInt32(0));
                    }
                }
            }
            return toReturn;
        }
        public static List<task> getAllTasksInDay(int day, int month)
        {
            SqliteCommand command = new SqliteCommand($"SELECT 'index' FROM days WHERE month = {month} AND year = {DateTime.Now.Year} AND day = {day}", db);
            int index = 0;
            List<task> toReturn = new List<task>();
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                index = reader.GetInt32(0);
            }
            command = new SqliteCommand($"SELECT * FROM '{index}'", db);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        toReturn.Add(new task(reader.GetString(1), reader.GetString(2), (taskState)reader.GetInt32(3)));
                    }
                }
            }
            return toReturn;
        }
        public static bool isHereTasks(int day, int month)
        {
            SqliteCommand command = new SqliteCommand($"SELECT 'index' FROM days WHERE month = {month} AND year = {DateTime.Now.Year} AND day = {day}", db);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
    }
    public struct task
    {
        public string taskName;
        public string taskInfo;
        public taskState taskState;
        public task(string name, string info, taskState state)
        {
            taskName = name;
            taskInfo = info;
            taskState = state;
        }
    }
    public enum taskState
    {
        ready = 0,
        workingOn = 1,
        needsToMake = 2
    }
}