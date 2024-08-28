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
            menuStrip = new MenuStrip();
            menuStrip_edit = new ToolStripMenuItem();
            schedulePresetsEditButton = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // daysTree
            // 
            daysTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            daysTree.Location = new Point(12, 56);
            daysTree.Name = "daysTree";
            daysTree.PathSeparator = "/";
            daysTree.Size = new Size(147, 442);
            daysTree.TabIndex = 0;
            // 
            // monthPicker
            // 
            monthPicker.FormattingEnabled = true;
            monthPicker.Items.AddRange(new object[] { "1. Январь (Січень)", "2. Февраль (Лютий)", "3. Март (Березень)", "4. Апрель (Квітень)", "5. Май (Травень)", "6. Июнь (Червень)", "7. Июль (Липень)", "8. Август (Серпень)", "9. Сентябрь (Вересень)", "10. Октябрь (Жовтень)", "11. Ноябрь (Листопад)", "12. Декабрь (Грудень)" });
            monthPicker.Location = new Point(12, 27);
            monthPicker.Name = "monthPicker";
            monthPicker.Size = new Size(147, 23);
            monthPicker.TabIndex = 1;
            monthPicker.SelectedIndexChanged += monthPicker_SelectedIndexChanged;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { menuStrip_edit });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // menuStrip_edit
            // 
            menuStrip_edit.DropDownItems.AddRange(new ToolStripItem[] { schedulePresetsEditButton });
            menuStrip_edit.Name = "menuStrip_edit";
            menuStrip_edit.Size = new Size(99, 20);
            menuStrip_edit.Text = "Редактировать";
            // 
            // schedulePresetsEditButton
            // 
            schedulePresetsEditButton.Name = "schedulePresetsEditButton";
            schedulePresetsEditButton.Size = new Size(199, 22);
            schedulePresetsEditButton.Text = "Заготовки расписаний";
            schedulePresetsEditButton.Click += schedulePresetsEditButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(daysTree);
            Controls.Add(monthPicker);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Планировщик занятий";
            Load += mainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView daysTree;
        private ComboBox monthPicker;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuStrip_edit;
        private ToolStripMenuItem schedulePresetsEditButton;
    }
}
