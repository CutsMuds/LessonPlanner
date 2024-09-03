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
            task8DeleteButton = new Button();
            task8Info = new RichTextBox();
            task8State = new ComboBox();
            task8Name = new TextBox();
            task7DeleteButton = new Button();
            task6DeleteButton = new Button();
            task5DeleteButton = new Button();
            task4DeleteButton = new Button();
            task3DeleteButton = new Button();
            task2DeleteButton = new Button();
            task1DeleteButton = new Button();
            task7Info = new RichTextBox();
            task7State = new ComboBox();
            task7Name = new TextBox();
            task6Info = new RichTextBox();
            task6State = new ComboBox();
            task6Name = new TextBox();
            task5Info = new RichTextBox();
            task4Info = new RichTextBox();
            task3Info = new RichTextBox();
            task2Info = new RichTextBox();
            task1Info = new RichTextBox();
            task5State = new ComboBox();
            task4State = new ComboBox();
            task3State = new ComboBox();
            task2State = new ComboBox();
            task1State = new ComboBox();
            task5Name = new TextBox();
            task4Name = new TextBox();
            task3Name = new TextBox();
            task2Name = new TextBox();
            task1Name = new TextBox();
            tasksGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // daysTree
            // 
            daysTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            daysTree.Location = new Point(12, 41);
            daysTree.Name = "daysTree";
            daysTree.PathSeparator = "/";
            daysTree.Size = new Size(184, 630);
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
            tasksGroupBox.Controls.Add(task8DeleteButton);
            tasksGroupBox.Controls.Add(task8Info);
            tasksGroupBox.Controls.Add(task8State);
            tasksGroupBox.Controls.Add(task8Name);
            tasksGroupBox.Controls.Add(task7DeleteButton);
            tasksGroupBox.Controls.Add(task6DeleteButton);
            tasksGroupBox.Controls.Add(task5DeleteButton);
            tasksGroupBox.Controls.Add(task4DeleteButton);
            tasksGroupBox.Controls.Add(task3DeleteButton);
            tasksGroupBox.Controls.Add(task2DeleteButton);
            tasksGroupBox.Controls.Add(task1DeleteButton);
            tasksGroupBox.Controls.Add(task7Info);
            tasksGroupBox.Controls.Add(task7State);
            tasksGroupBox.Controls.Add(task7Name);
            tasksGroupBox.Controls.Add(task6Info);
            tasksGroupBox.Controls.Add(task6State);
            tasksGroupBox.Controls.Add(task6Name);
            tasksGroupBox.Controls.Add(task5Info);
            tasksGroupBox.Controls.Add(task4Info);
            tasksGroupBox.Controls.Add(task3Info);
            tasksGroupBox.Controls.Add(task2Info);
            tasksGroupBox.Controls.Add(task1Info);
            tasksGroupBox.Controls.Add(task5State);
            tasksGroupBox.Controls.Add(task4State);
            tasksGroupBox.Controls.Add(task3State);
            tasksGroupBox.Controls.Add(task2State);
            tasksGroupBox.Controls.Add(task1State);
            tasksGroupBox.Controls.Add(task5Name);
            tasksGroupBox.Controls.Add(task4Name);
            tasksGroupBox.Controls.Add(task3Name);
            tasksGroupBox.Controls.Add(task2Name);
            tasksGroupBox.Controls.Add(task1Name);
            tasksGroupBox.Location = new Point(202, 12);
            tasksGroupBox.Name = "tasksGroupBox";
            tasksGroupBox.Size = new Size(382, 659);
            tasksGroupBox.TabIndex = 2;
            tasksGroupBox.TabStop = false;
            tasksGroupBox.Text = "Задания:";
            // 
            // task8DeleteButton
            // 
            task8DeleteButton.Location = new Point(292, 575);
            task8DeleteButton.Name = "task8DeleteButton";
            task8DeleteButton.Size = new Size(78, 73);
            task8DeleteButton.TabIndex = 43;
            task8DeleteButton.Text = "Удалить";
            task8DeleteButton.UseVisualStyleBackColor = true;
            task8DeleteButton.Visible = false;
            // 
            // task8Info
            // 
            task8Info.Location = new Point(19, 604);
            task8Info.Name = "task8Info";
            task8Info.Size = new Size(267, 44);
            task8Info.TabIndex = 42;
            task8Info.Text = "";
            task8Info.Visible = false;
            // 
            // task8State
            // 
            task8State.FormattingEnabled = true;
            task8State.Location = new Point(177, 575);
            task8State.Name = "task8State";
            task8State.Size = new Size(109, 23);
            task8State.TabIndex = 41;
            task8State.Visible = false;
            // 
            // task8Name
            // 
            task8Name.Location = new Point(19, 575);
            task8Name.Name = "task8Name";
            task8Name.Size = new Size(152, 23);
            task8Name.TabIndex = 40;
            task8Name.Visible = false;
            // 
            // task7DeleteButton
            // 
            task7DeleteButton.Location = new Point(292, 496);
            task7DeleteButton.Name = "task7DeleteButton";
            task7DeleteButton.Size = new Size(78, 73);
            task7DeleteButton.TabIndex = 39;
            task7DeleteButton.Text = "Удалить";
            task7DeleteButton.UseVisualStyleBackColor = true;
            task7DeleteButton.Visible = false;
            // 
            // task6DeleteButton
            // 
            task6DeleteButton.Location = new Point(292, 417);
            task6DeleteButton.Name = "task6DeleteButton";
            task6DeleteButton.Size = new Size(78, 73);
            task6DeleteButton.TabIndex = 38;
            task6DeleteButton.Text = "Удалить";
            task6DeleteButton.UseVisualStyleBackColor = true;
            task6DeleteButton.Visible = false;
            // 
            // task5DeleteButton
            // 
            task5DeleteButton.Location = new Point(292, 338);
            task5DeleteButton.Name = "task5DeleteButton";
            task5DeleteButton.Size = new Size(78, 73);
            task5DeleteButton.TabIndex = 37;
            task5DeleteButton.Text = "Удалить";
            task5DeleteButton.UseVisualStyleBackColor = true;
            task5DeleteButton.Visible = false;
            // 
            // task4DeleteButton
            // 
            task4DeleteButton.Location = new Point(292, 259);
            task4DeleteButton.Name = "task4DeleteButton";
            task4DeleteButton.Size = new Size(78, 73);
            task4DeleteButton.TabIndex = 36;
            task4DeleteButton.Text = "Удалить";
            task4DeleteButton.UseVisualStyleBackColor = true;
            task4DeleteButton.Visible = false;
            // 
            // task3DeleteButton
            // 
            task3DeleteButton.Location = new Point(292, 180);
            task3DeleteButton.Name = "task3DeleteButton";
            task3DeleteButton.Size = new Size(78, 73);
            task3DeleteButton.TabIndex = 35;
            task3DeleteButton.Text = "Удалить";
            task3DeleteButton.UseVisualStyleBackColor = true;
            task3DeleteButton.Visible = false;
            // 
            // task2DeleteButton
            // 
            task2DeleteButton.Location = new Point(292, 101);
            task2DeleteButton.Name = "task2DeleteButton";
            task2DeleteButton.Size = new Size(78, 73);
            task2DeleteButton.TabIndex = 34;
            task2DeleteButton.Text = "Удалить";
            task2DeleteButton.UseVisualStyleBackColor = true;
            task2DeleteButton.Visible = false;
            // 
            // task1DeleteButton
            // 
            task1DeleteButton.Location = new Point(292, 22);
            task1DeleteButton.Name = "task1DeleteButton";
            task1DeleteButton.Size = new Size(78, 73);
            task1DeleteButton.TabIndex = 33;
            task1DeleteButton.Text = "Удалить";
            task1DeleteButton.UseVisualStyleBackColor = true;
            task1DeleteButton.Visible = false;
            // 
            // task7Info
            // 
            task7Info.Location = new Point(19, 525);
            task7Info.Name = "task7Info";
            task7Info.Size = new Size(267, 44);
            task7Info.TabIndex = 32;
            task7Info.Text = "";
            task7Info.Visible = false;
            // 
            // task7State
            // 
            task7State.FormattingEnabled = true;
            task7State.Location = new Point(177, 496);
            task7State.Name = "task7State";
            task7State.Size = new Size(109, 23);
            task7State.TabIndex = 31;
            task7State.Visible = false;
            // 
            // task7Name
            // 
            task7Name.Location = new Point(19, 496);
            task7Name.Name = "task7Name";
            task7Name.Size = new Size(152, 23);
            task7Name.TabIndex = 30;
            task7Name.Visible = false;
            // 
            // task6Info
            // 
            task6Info.Location = new Point(19, 446);
            task6Info.Name = "task6Info";
            task6Info.Size = new Size(267, 44);
            task6Info.TabIndex = 29;
            task6Info.Text = "";
            task6Info.Visible = false;
            // 
            // task6State
            // 
            task6State.FormattingEnabled = true;
            task6State.Location = new Point(177, 417);
            task6State.Name = "task6State";
            task6State.Size = new Size(109, 23);
            task6State.TabIndex = 28;
            task6State.Visible = false;
            // 
            // task6Name
            // 
            task6Name.Location = new Point(19, 417);
            task6Name.Name = "task6Name";
            task6Name.Size = new Size(152, 23);
            task6Name.TabIndex = 27;
            task6Name.Visible = false;
            // 
            // task5Info
            // 
            task5Info.Location = new Point(19, 367);
            task5Info.Name = "task5Info";
            task5Info.Size = new Size(267, 44);
            task5Info.TabIndex = 26;
            task5Info.Text = "";
            task5Info.Visible = false;
            // 
            // task4Info
            // 
            task4Info.Location = new Point(19, 288);
            task4Info.Name = "task4Info";
            task4Info.Size = new Size(267, 44);
            task4Info.TabIndex = 25;
            task4Info.Text = "";
            task4Info.Visible = false;
            // 
            // task3Info
            // 
            task3Info.Location = new Point(19, 209);
            task3Info.Name = "task3Info";
            task3Info.Size = new Size(267, 44);
            task3Info.TabIndex = 24;
            task3Info.Text = "";
            task3Info.Visible = false;
            // 
            // task2Info
            // 
            task2Info.Location = new Point(19, 130);
            task2Info.Name = "task2Info";
            task2Info.Size = new Size(267, 44);
            task2Info.TabIndex = 23;
            task2Info.Text = "";
            task2Info.Visible = false;
            // 
            // task1Info
            // 
            task1Info.Location = new Point(19, 51);
            task1Info.Name = "task1Info";
            task1Info.Size = new Size(267, 44);
            task1Info.TabIndex = 22;
            task1Info.Text = "";
            task1Info.Visible = false;
            // 
            // task5State
            // 
            task5State.FormattingEnabled = true;
            task5State.Location = new Point(177, 338);
            task5State.Name = "task5State";
            task5State.Size = new Size(109, 23);
            task5State.TabIndex = 19;
            task5State.Visible = false;
            // 
            // task4State
            // 
            task4State.FormattingEnabled = true;
            task4State.Location = new Point(177, 259);
            task4State.Name = "task4State";
            task4State.Size = new Size(109, 23);
            task4State.TabIndex = 18;
            task4State.Visible = false;
            // 
            // task3State
            // 
            task3State.FormattingEnabled = true;
            task3State.Location = new Point(177, 180);
            task3State.Name = "task3State";
            task3State.Size = new Size(109, 23);
            task3State.TabIndex = 18;
            task3State.Visible = false;
            // 
            // task2State
            // 
            task2State.FormattingEnabled = true;
            task2State.Location = new Point(177, 101);
            task2State.Name = "task2State";
            task2State.Size = new Size(109, 23);
            task2State.TabIndex = 16;
            task2State.Visible = false;
            // 
            // task1State
            // 
            task1State.FormattingEnabled = true;
            task1State.Location = new Point(177, 22);
            task1State.Name = "task1State";
            task1State.Size = new Size(109, 23);
            task1State.TabIndex = 15;
            task1State.Visible = false;
            // 
            // task5Name
            // 
            task5Name.Location = new Point(19, 338);
            task5Name.Name = "task5Name";
            task5Name.Size = new Size(152, 23);
            task5Name.TabIndex = 10;
            task5Name.Visible = false;
            // 
            // task4Name
            // 
            task4Name.Location = new Point(19, 259);
            task4Name.Name = "task4Name";
            task4Name.Size = new Size(152, 23);
            task4Name.TabIndex = 8;
            task4Name.Visible = false;
            // 
            // task3Name
            // 
            task3Name.Location = new Point(19, 180);
            task3Name.Name = "task3Name";
            task3Name.Size = new Size(152, 23);
            task3Name.TabIndex = 6;
            task3Name.Visible = false;
            // 
            // task2Name
            // 
            task2Name.Location = new Point(19, 101);
            task2Name.Name = "task2Name";
            task2Name.Size = new Size(152, 23);
            task2Name.TabIndex = 2;
            task2Name.Visible = false;
            // 
            // task1Name
            // 
            task1Name.Location = new Point(19, 22);
            task1Name.Name = "task1Name";
            task1Name.Size = new Size(152, 23);
            task1Name.TabIndex = 0;
            task1Name.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 683);
            Controls.Add(tasksGroupBox);
            Controls.Add(daysTree);
            Controls.Add(monthPicker);
            MaximumSize = new Size(612, 722);
            MinimumSize = new Size(612, 321);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Планировщик занятий";
            Load += mainForm_Load;
            tasksGroupBox.ResumeLayout(false);
            tasksGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView daysTree;
        private ComboBox monthPicker;
        private GroupBox tasksGroupBox;
        private TextBox task5Name;
        private TextBox task4Name;
        private TextBox task3Name;
        private TextBox task2Name;
        private TextBox task1Name;
        private ComboBox task1State;
        private ComboBox task5State;
        private ComboBox task4State;
        private ComboBox task3State;
        private ComboBox task2State;
        private RichTextBox task5Info;
        private RichTextBox task4Info;
        private RichTextBox task3Info;
        private RichTextBox task2Info;
        private RichTextBox task1Info;
        private RichTextBox task7Info;
        private ComboBox task7State;
        private TextBox task7Name;
        private RichTextBox task6Info;
        private ComboBox task6State;
        private TextBox task6Name;
        private Button task2DeleteButton;
        private Button task1DeleteButton;
        private Button task7DeleteButton;
        private Button task6DeleteButton;
        private Button task5DeleteButton;
        private Button task4DeleteButton;
        private Button task3DeleteButton;
        private Button task8DeleteButton;
        private RichTextBox task8Info;
        private ComboBox task8State;
        private TextBox task8Name;
    }
}
