using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VixenEditor
{
    public class TimeSpanUpDown: UpDownBase
    {
        const string FormatString = @"m\:ss\.fff";
        TimeSpan timeSpan;

        public TimeSpan Increment { get; set; } = TimeSpan.FromMilliseconds(100);
        public TimeSpan MinimumValue { get; set; } = TimeSpan.FromMilliseconds(0);
        public TimeSpan MaximumValue { get; set; } = TimeSpan.FromMilliseconds(60000);

        public TimeSpanUpDown()
        {
            timeSpan = new TimeSpan();
            Text = timeSpan.ToString(FormatString);
        }

        public TimeSpan Value
        {
            get {
                UpdateEditText();
                return timeSpan;
            }

            set
            {
                timeSpan = value;
                UserEdit = false;
                UpdateEditText();
            }
        }

        public override void DownButton()
        {
            UpdateEditText();

            timeSpan = timeSpan - Increment;
            if (timeSpan < MinimumValue)
                timeSpan = MinimumValue;

            UpdateEditText();
        }

        public override void UpButton()
        {
            UpdateEditText();

            timeSpan = timeSpan + Increment;
            if (timeSpan > MaximumValue)
                timeSpan = MaximumValue;

            UpdateEditText();
        }

        protected override void UpdateEditText()
        {
            if (UserEdit) {
                TimeSpan newTimeSpan;
                if (TimeSpan.TryParseExact(Text, FormatString, CultureInfo.CurrentCulture, out newTimeSpan)) {
                    timeSpan = newTimeSpan;
                }
            }

            Text = timeSpan.ToString(FormatString);
            UserEdit = false;
        }

    }
}
