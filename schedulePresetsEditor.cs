using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonPlanner
{
    public partial class schedulePresetsEditor : Form
    {
        List<schedulePreset> schedulePresets = new List<schedulePreset>();
        public schedulePresetsEditor()
        {
            InitializeComponent();
        }

        private void schedulePresetsEditor_Load(object sender, EventArgs e)
        {
            updateComboBox();
        }
        private void updateComboBox()
        {
            schedulePresetComboBox.Items.Clear();
            schedulePresets = dbController.getSchedulePresets();
            for (int i = 0; i < schedulePresets.Count; i++)
            {
                schedulePresetComboBox.Items.Add(schedulePresets[i].presetName);
            }
            if (schedulePresets.Count > 0) schedulePresetComboBox.SelectedIndex = schedulePresetComboBox.Items.Count - 1;
        }
        private void createScheduleButton_Click(object sender, EventArgs e)
        {
            schedulePresetCreatorDialogue schedulePresetCreator = new schedulePresetCreatorDialogue();
            if (schedulePresetCreator.ShowDialog() == DialogResult.OK)
            {
                updateComboBox();
            }
        }
    }
}
