namespace LessonPlanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void mainForm_Load(object sender, EventArgs e)
        {
            dbController.init();
            monthPicker.SelectedIndex = DateTime.Now.Month - 1;
        }
        public void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            daysTree.Nodes.Clear();
            int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, monthPicker.SelectedIndex + 1);
            for (int day = 1; day <= daysCount; day++)
            {
                string dayName = new DateTime(DateTime.Now.Year, monthPicker.SelectedIndex + 1, day).ToString("ddd");
                daysTree.Nodes.Add($"{day}: {dayName}");
            }

            List<int> days = dbController.getAllTasksDaysInMonth(monthPicker.SelectedIndex + 1);

            for (int i = 0; i < days.Count; i++)
            {
                List<task> tasks = dbController.getAllTasksInDay(days[i], monthPicker.SelectedIndex + 1);
                for (int j = 0; j < tasks.Count; j++)
                {
                    daysTree.Nodes[days[i] - 1].Nodes.Add(tasks[j].taskName);
                }
            }
        }
        private void daysTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            daysTree.SelectedNode = e.Node;
            for (int i = 0; i < daysTree.Nodes.Count; i++)
            {
                if (!daysTree.Nodes[i].IsSelected) daysTree.Nodes[i].Collapse();
            }
        }
    }
}
