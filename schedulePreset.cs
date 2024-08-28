using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonPlanner
{
    public class schedulePreset
    {
        public int dbId;
        public string presetName;
        public string[] presetTasks;
        public schedulePreset(int id, string name, string tasks)
        {
            dbId = id;
            presetName = name;
            presetTasks = tasks.Split(',');
        }
    }
}
