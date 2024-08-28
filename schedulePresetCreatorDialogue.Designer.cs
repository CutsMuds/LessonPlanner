namespace LessonPlanner
{
    partial class schedulePresetCreatorDialogue
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
            nameField = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameField
            // 
            nameField.Location = new Point(12, 12);
            nameField.Name = "nameField";
            nameField.Size = new Size(303, 23);
            nameField.TabIndex = 0;
            nameField.Text = "Имя";
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 41);
            okButton.Name = "okButton";
            okButton.Size = new Size(141, 23);
            okButton.TabIndex = 1;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(174, 41);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(141, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // scheduleCreatorDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 75);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(nameField);
            Name = "scheduleCreatorDialogue";
            Text = "Создать готовое рассписание";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameField;
        private Button okButton;
        private Button cancelButton;
    }
}