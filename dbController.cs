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
    }
}
