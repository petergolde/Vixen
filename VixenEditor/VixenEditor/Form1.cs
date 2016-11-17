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


        private void buttonSaveMainFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string fileName = saveFileDialog.FileName;
                vixenFile.Save(fileName);
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

        private void DoEdit()
        {
            TimeSpan triggerStart = upDownStartTime.Value;
            TimeSpan triggerEnd = upDownEndTime.Value;
            int triggerChannel = (int) upDownTriggerChannel.Value;
            int every = (int)upDownTriggerEvery.Value;

            TimeSpan templateStart = upDownTemplateStartTime.Value;
            TimeSpan templateEnd = upDownTemplateEndTime.Value;
            TimeSpan templateAlign = upDownTemplateAlign.Value;

            int[] channelsCopy = ParseChannelNumbers(textBoxCopyTo.Text);
            int[] channelsMerge = ParseChannelNumbers(textBoxMergeTo.Text);

            EditVixen editVixen = new EditVixen(vixenFile, templateFile);
            foreach (TimeSpan triggerLocation in editVixen.EnumTriggerPoints(triggerStart, triggerEnd, triggerChannel, every)) {
                editVixen.CopyTemplate(templateStart, templateEnd, templateAlign, triggerLocation, channelsCopy, false);
                editVixen.CopyTemplate(templateStart, templateEnd, templateAlign, triggerLocation, channelsMerge, true);
            }
        }

        int[] ParseChannelNumbers(string text)
        {
            List<int> result = new List<int>();
            string[] split = text.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in split) {
                if (s.Contains('-')) {
                    string[] range = s.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (range.Length != 2) {
                        throw new Exception("Bad channel numbers: " + text);
                    }
                    int first = int.Parse(range[0]), last = int.Parse(range[1]);
                    for (int i = first; i <= last; ++i)
                        result.Add(i);
                }
                else {
                    result.Add(int.Parse(s));
                }
            }

            return result.ToArray();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            DoEdit();
            MessageBox.Show("Edit has been performed. Click Save to save file.");
        }
    }
}
