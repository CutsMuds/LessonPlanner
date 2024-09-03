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
            SuspendLayout();
            // 
            // daysTree
            // 
            daysTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            daysTree.Location = new Point(12, 41);
            daysTree.Name = "daysTree";
            daysTree.PathSeparator = "/";
            daysTree.Size = new Size(147, 457);
            daysTree.TabIndex = 0;
            daysTree.AfterExpand += daysTree_AfterExpand;
            // 
            // monthPicker
            // 
            monthPicker.FormattingEnabled = true;
            monthPicker.Items.AddRange(new object[] { "1. Январь (Січень)", "2. Февраль (Лютий)", "3. Март (Березень)", "4. Апрель (Квітень)", "5. Май (Травень)", "6. Июнь (Червень)", "7. Июль (Липень)", "8. Август (Серпень)", "9. Сентябрь (Вересень)", "10. Октябрь (Жовтень)", "11. Ноябрь (Листопад)", "12. Декабрь (Грудень)" });
            monthPicker.Location = new Point(12, 12);
            monthPicker.Name = "monthPicker";
            monthPicker.Size = new Size(147, 23);
            monthPicker.TabIndex = 1;
            monthPicker.SelectedIndexChanged += monthPicker_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
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
    }
}
