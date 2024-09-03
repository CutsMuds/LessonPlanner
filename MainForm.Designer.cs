namespace LessonPlanner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            daysTree = new TreeView();
            monthPicker = new ComboBox();
            tasksGroupBox = new GroupBox();
            saveAllTasksButton = new Button();
            addTaskButton = new Button();
            tasksGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // daysTree
            // 
            daysTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            daysTree.Location = new Point(12, 41);
            daysTree.Name = "daysTree";
            daysTree.PathSeparator = "/";
            daysTree.Size = new Size(184, 657);
            daysTree.TabIndex = 0;
            daysTree.AfterSelect += daysTree_AfterSelect;
            // 
            // monthPicker
            // 
            monthPicker.FormattingEnabled = true;
            monthPicker.Items.AddRange(new object[] { "1. Январь (Січень)", "2. Февраль (Лютий)", "3. Март (Березень)", "4. Апрель (Квітень)", "5. Май (Травень)", "6. Июнь (Червень)", "7. Июль (Липень)", "8. Август (Серпень)", "9. Сентябрь (Вересень)", "10. Октябрь (Жовтень)", "11. Ноябрь (Листопад)", "12. Декабрь (Грудень)" });
            monthPicker.Location = new Point(12, 12);
            monthPicker.Name = "monthPicker";
            monthPicker.Size = new Size(184, 23);
            monthPicker.TabIndex = 1;
            monthPicker.SelectedIndexChanged += monthPicker_SelectedIndexChanged;
            // 
            // tasksGroupBox
            // 
            tasksGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tasksGroupBox.Controls.Add(saveAllTasksButton);
            tasksGroupBox.Controls.Add(addTaskButton);
            tasksGroupBox.Location = new Point(202, 12);
            tasksGroupBox.Name = "tasksGroupBox";
            tasksGroupBox.Size = new Size(382, 686);
            tasksGroupBox.TabIndex = 2;
            tasksGroupBox.TabStop = false;
            tasksGroupBox.Text = "Задания:";
            // 
            // saveAllTasksButton
            // 
            saveAllTasksButton.Location = new Point(6, 657);
            saveAllTasksButton.Name = "saveAllTasksButton";
            saveAllTasksButton.Size = new Size(370, 23);
            saveAllTasksButton.TabIndex = 1;
            saveAllTasksButton.Text = "Сохранить все";
            saveAllTasksButton.UseVisualStyleBackColor = true;
            saveAllTasksButton.Click += saveAllTasksButton_Click;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(6, 630);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(370, 23);
            addTaskButton.TabIndex = 0;
            addTaskButton.Text = "Добавить задание";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 710);
            Controls.Add(tasksGroupBox);
            Controls.Add(daysTree);
            Controls.Add(monthPicker);
            MinimumSize = new Size(612, 321);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Планировщик занятий";
            Load += mainForm_Load;
            tasksGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView daysTree;
        private ComboBox monthPicker;
        private GroupBox tasksGroupBox;
        private Button addTaskButton;
        private Button saveAllTasksButton;
    }
}
