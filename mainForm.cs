using System;
using System.Threading.Tasks;

namespace LessonPlanner
{
    public partial class MainForm : Form
    {
        const int taskMaxCount = 8;
        private int currentSelectedDay = 1;
        private List<task> currentTasks = new List<task>();
        TextBox[] taskNames = new TextBox[taskMaxCount];
        ComboBox[] taskStates = new ComboBox[taskMaxCount];
        RichTextBox[] taskInfos = new RichTextBox[taskMaxCount];
        Button[] taskDeleteButtons = new Button[taskMaxCount];

        public MainForm()
        {
            InitializeComponent();
            tasksGroupBox.SuspendLayout();

            for (int i = 0; i < taskMaxCount; i++)
            {
                taskNames[i] = new TextBox();
                taskStates[i] = new ComboBox();
                taskInfos[i] = new RichTextBox();
                taskDeleteButtons[i] = new Button();

                tasksGroupBox.Controls.Add(taskNames[i]);
                tasksGroupBox.Controls.Add(taskStates[i]);
                tasksGroupBox.Controls.Add(taskInfos[i]);
                tasksGroupBox.Controls.Add(taskDeleteButtons[i]);

                taskNames[i].Location = new Point(19, 22 + i * 79);
                taskNames[i].Name = $"task{i + 1}Name";
                taskNames[i].Size = new Size(152, 23);
                taskNames[i].Visible = false;

                taskStates[i].FormattingEnabled = true;
                taskStates[i].Items.AddRange(["Выполнено", "Выполняется", "Не выполнено"]);
                taskStates[i].Location = new Point(177, 22 + i * 79);
                taskStates[i].Name = $"task{i + 1}State";
                taskStates[i].Size = new Size(109, 23);
                taskStates[i].Visible = false;

                taskInfos[i].Location = new Point(19, 51 + i * 79);
                taskInfos[i].Name = $"task{i + 1}Info";
                taskInfos[i].Size = new Size(267, 44);
                taskInfos[i].Text = "";
                taskInfos[i].Visible = false;

                taskDeleteButtons[i].Location = new Point(292, 22 + i * 79);
                taskDeleteButtons[i].Name = $"task{i + 1}DeleteButton";
                taskDeleteButtons[i].Size = new Size(78, 73);
                taskDeleteButtons[i].Text = "Удалить и\nсохранить";
                taskDeleteButtons[i].UseVisualStyleBackColor = true;
                taskDeleteButtons[i].Click += taskDeleteButtonClick;
                taskDeleteButtons[i].Visible = false;
            }

            tasksGroupBox.ResumeLayout();
        }
        public void mainForm_Load(object sender, EventArgs e)
        {
            dbController.init();
            monthPicker.SelectedIndex = DateTime.Now.Month - 1;
        }
        public void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDaysTree();
        }
        private void updateDaysTree()
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
            daysTree.SelectedNode = daysTree.Nodes[currentSelectedDay - 1];
        }
        private void daysTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = daysTree.SelectedNode;
            if (daysTree.SelectedNode.Parent != null)
            {
                node = daysTree.SelectedNode.Parent;
            }
            currentSelectedDay = node.Index + 1;
            loadTasks();
        }
        private void loadTasks()
        {
            TreeNode node = daysTree.SelectedNode;
            if (daysTree.SelectedNode.Parent != null)
            {
                node = daysTree.SelectedNode.Parent;
            }

            for (int i = 0; i < taskMaxCount; i++)
            {
                taskNames[i].Visible = false;
                taskStates[i].Visible = false;
                taskInfos[i].Visible = false;
                taskDeleteButtons[i].Visible = false;
            }

            if (dbController.isHereTasks(currentSelectedDay, monthPicker.SelectedIndex + 1))
            {
                tasksGroupBox.Text = $"Задания({node.Text}):";
                currentTasks = dbController.getAllTasksInDay(currentSelectedDay, monthPicker.SelectedIndex + 1);
                if (currentTasks.Count == 8) addTaskButton.Visible = false;
                else addTaskButton.Visible = true;
                for (int i = 0; i < currentTasks.Count; i++)
                {
                    taskNames[i].Text = currentTasks[i].taskName;
                    taskNames[i].Visible = true;
                    taskStates[i].SelectedIndex = (int)currentTasks[i].taskState;
                    taskStates[i].Visible = true;
                    taskInfos[i].Text = currentTasks[i].taskInfo;
                    taskInfos[i].Visible = true;
                    taskDeleteButtons[i].Visible = true;
                }
            }
            else
            {
                tasksGroupBox.Text = $"Задания({node.Text}): отсутствуют";
                addTaskButton.Visible = true;
            }
        }
        private void taskDeleteButtonClick(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            dbController.deleteTask(currentSelectedDay, monthPicker.SelectedIndex + 1, currentTasks[Convert.ToInt32(senderButton.Name[4].ToString()) - 1].taskId);

            loadTasks();
            updateDaysTree();
        }
        private void saveAllTasksButton_Click(object sender, EventArgs e)
        {
            if (dbController.isHereTasks(currentSelectedDay, monthPicker.SelectedIndex + 1))
            {
                int taskDayId = dbController.getTaskDayId(currentSelectedDay, monthPicker.SelectedIndex + 1);
                
                for(int i = 0; i < currentTasks.Count; i++)
                {
                    currentTasks[i] = new task(currentTasks[i].taskId, taskNames[i].Text, taskInfos[i].Text, (taskState)taskStates[i].SelectedIndex);
                    dbController.updateTask(taskDayId, currentTasks[i]);
                }

                updateDaysTree();
            }
        }
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            dbController.addTask(currentSelectedDay, monthPicker.SelectedIndex + 1);
            loadTasks();
            updateDaysTree();
        }
    }
}