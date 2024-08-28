namespace LessonPlanner
{
    partial class schedulePresetsEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            schedulePresetComboBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // schedulePresetComboBox
            // 
            schedulePresetComboBox.FormattingEnabled = true;
            schedulePresetComboBox.Location = new Point(12, 12);
            schedulePresetComboBox.Name = "schedulePresetComboBox";
            schedulePresetComboBox.Size = new Size(146, 23);
            schedulePresetComboBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(164, 12);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 1;
            button1.Text = "Создать новое";
            button1.UseVisualStyleBackColor = true;
            // 
            // schedulePresetsEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(schedulePresetComboBox);
            Name = "schedulePresetsEditor";
            Text = "Редактор готовых рассписаний";
            Load += schedulePresetsEditor_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox schedulePresetComboBox;
        private Button button1;
    }
}