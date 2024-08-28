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
        List<schedulePreset> schedulePresets;
        public schedulePresetsEditor()
        {
            InitializeComponent();
        }

        private void schedulePresetsEditor_Load(object sender, EventArgs e)
        {
            schedulePresets = dbController.getSchedulePresets();
            for(int i = 0; i < schedulePresets.Count; i++)
            {
                schedulePresetComboBox.Items.Add(schedulePresets[i].presetName);
            }
        }
    }
}
