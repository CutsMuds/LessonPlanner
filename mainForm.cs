namespace LessonPlanner
{
    public partial class MainForm : Form
    {
        public int year = DateTime.Now.Year;
        public MainForm()
        {
            InitializeComponent();
        }
        public void mainForm_Load(object sender, EventArgs e)
        {
            monthPicker.SelectedIndex = DateTime.Now.Month - 1;
            dbController.init();
        }
        public void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            daysTree.Nodes.Clear();
            int daysCount = DateTime.DaysInMonth(year, monthPicker.SelectedIndex + 1);
            for (int day = 1; day <= daysCount; day++)
            {
                string dayName = new DateTime(year, monthPicker.SelectedIndex + 1, day).ToString("ddd");
                daysTree.Nodes.Add($"{day}: {dayName}");
            }
        }
        public void schedulePresetsEditButton_Click(object sender, EventArgs e)
        {
            schedulePresetsEditor Editor = new schedulePresetsEditor();
            Editor.ShowDialog();
        }
    }
}
