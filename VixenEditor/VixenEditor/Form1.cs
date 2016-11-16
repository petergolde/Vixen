using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VixenEditor
{
    public partial class Form1: Form
    {
        VixenFile vixenFile;
        VixenFile templateFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadMainFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog(this) == DialogResult.OK) {
                string fileName = openFileDialogMain.FileName;
                vixenFile = new VixenFile(fileName);
                UpdateMainFileControls();
            }
        }

        private void buttonLoadTemplate_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog(this) == DialogResult.OK) {
                string fileName = openFileDialogMain.FileName;
                templateFile = new VixenFile(fileName);
                UpdateTemplateFileControls();
            }
        }

        private void UpdateMainFileControls()
        {
            labelFileName.Text = vixenFile.BaseFileName;
            labelLength.Text = vixenFile.TotalLength.ToString(@"m\:ss\.fff");
            labelPeriod.Text = vixenFile.PeriodLength.ToString(@"s\.fff");
            labelChannels.Text = vixenFile.Channels.ToString();

            upDownTriggerChannel.Value = 1;
            upDownTriggerChannel.Maximum = vixenFile.Channels;
            upDownTriggerChannel.Minimum = 1;

            upDownStartTime.MinimumValue = upDownEndTime.MinimumValue = TimeSpan.FromMilliseconds(0);
            upDownStartTime.MaximumValue = upDownEndTime.MaximumValue = vixenFile.TotalLength;
            upDownStartTime.Increment = upDownEndTime.Increment = vixenFile.PeriodLength;

            textBoxCopyTo.Text = "";
            textBoxMergeTo.Text = string.Format("{0}-{1}", 1, vixenFile.Channels);
        }

        private void UpdateTemplateFileControls()
        {
            labelFileNameTemplate.Text = templateFile.BaseFileName;
            labelLengthTemplate.Text = templateFile.TotalLength.ToString(@"m\:ss\.fff");
            labelPeriodTemplate.Text = templateFile.PeriodLength.ToString(@"s\.fff");
            labelChannelsTemplate.Text = templateFile.Channels.ToString();

            upDownTemplateStartTime.MinimumValue = upDownTemplateEndTime.MinimumValue = upDownTemplateAlign.MinimumValue = TimeSpan.FromMilliseconds(0);
            upDownTemplateStartTime.MaximumValue = upDownTemplateEndTime.MaximumValue = upDownTemplateAlign.MaximumValue = templateFile.TotalLength;
            upDownTemplateStartTime.Increment = upDownTemplateEndTime.Increment = upDownTemplateAlign.Increment = templateFile.PeriodLength;
        }
    }
}
