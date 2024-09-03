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
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // daysTree
            // 
            daysTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            daysTree.Location = new Point(12, 41);
            daysTree.Name = "daysTree";
            daysTree.PathSeparator = "/";
            daysTree.Size = new Size(184, 457);
            daysTree.TabIndex = 0;
            daysTree.AfterExpand += daysTree_AfterExpand;
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
            // groupBox1
            // 
            groupBox1.Location = new Point(202, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 486);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задания";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 510);
            Controls.Add(groupBox1);
            Controls.Add(daysTree);
            Controls.Add(monthPicker);
            Name = "MainForm";
            Text = "Планировщик занятий";
            Load += mainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView daysTree;
        private ComboBox monthPicker;
        private GroupBox groupBox1;
    }
}
