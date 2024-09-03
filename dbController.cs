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
            SqliteCommand command = new SqliteCommand($"SELECT \"index\" FROM days WHERE month = {month} AND year = {DateTime.Now.Year} AND day = {day}", db);
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
                        toReturn.Add(new task(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), (taskState)reader.GetInt32(3)));
                    }
                }
            }
            return toReturn;
        }
        public static bool isHereTasks(int day, int month)
        {
            SqliteCommand command = new SqliteCommand($"SELECT \"index\" FROM days WHERE month = {month} AND year = {DateTime.Now.Year} AND day = {day}", db);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
        public static void deleteTask(int day, int month, int id)
        {
            SqliteCommand command = new SqliteCommand($"SELECT \"index\" FROM days WHERE month = {month} AND year = {DateTime.Now.Year} AND day = {day}", db);
            int index = 0;
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                index = reader.GetInt32(0);
                reader.Close();
            }
            command = new SqliteCommand($"DELETE FROM '{index}' WHERE \"index\" = {id}", db);
            command.ExecuteNonQuery();
        }
        public static int getTaskDayId(int day, int month)
        {
            SqliteCommand command = new SqliteCommand($"SELECT \"index\" FROM days WHERE month = {month} AND year = {DateTime.Now.Year} AND day = {day}", db);
            int index = 0;
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                index = reader.GetInt32(0);
            }
            return index;
        }
        public static void addTask(int day, int month)
        {
            SqliteCommand command;
            int currentIndex = getHighestDayIndex();
            if (!isHereTasks(day, month))
            {
                currentIndex++;
                command = new SqliteCommand($"CREATE TABLE '{currentIndex}' (\r\n\t\"index\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"taskName\"\tTEXT NOT NULL,\r\n\t\"taskInfo\"\tTEXT NOT NULL,\r\n\t\"taskState\"\tINTEGER NOT NULL,\r\n\tPRIMARY KEY(\"index\")\r\n)", db);
                command.ExecuteNonQuery();
                command = new SqliteCommand($"INSERT INTO days VALUES({currentIndex}, {DateTime.Now.Year}, {month}, {day})", db);
                command.ExecuteNonQuery();
            }
            else
            {
                command = new SqliteCommand($"SELECT \"index\" FROM days WHERE month = {month} AND year = {DateTime.Now.Year} AND day = {day}", db);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    currentIndex = reader.GetInt32(0);
                }
            }

            command = new SqliteCommand($"INSERT INTO \"{currentIndex}\" VALUES({getHighestTaskIndex(currentIndex) + 1}, ' ', ' ', 2)", db);
            command.ExecuteNonQuery();
        }
        public static int getHighestDayIndex()
        {
            SqliteCommand command = new SqliteCommand("SELECT MAX(\"index\") FROM days", db);
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
        public static int getHighestTaskIndex(int taskIndex)
        {
            SqliteCommand command = new SqliteCommand($"SELECT MAX(\"index\") FROM '{taskIndex}'", db);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.IsDBNull(0))
                        return reader.GetInt32(0);

                }
                return -1;
            }
        }
        public static void updateTask(int taskDayIndex, task newTask)
        {
            string com = $"UPDATE '{taskDayIndex}' SET taskName = '{newTask.taskName}', taskInfo = '{newTask.taskInfo}', taskState = '{(int)newTask.taskState}' WHERE \"index\" = {newTask.taskId}";
            SqliteCommand command = new SqliteCommand(com, db);
            command.ExecuteNonQuery();
        }
    }
    public struct task
    {
        public int taskId;
        public string taskName;
        public string taskInfo;
        public taskState taskState;
        public task(int id, string name, string info, taskState state)
        {
            taskId = id;
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