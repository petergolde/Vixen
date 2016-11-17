using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VixenEditor
{
    class EditVixen
    {
        VixenFile mainFile, template;


        public EditVixen(VixenFile mainFile, VixenFile template)
        {
            this.mainFile = mainFile;
            this.template = template;
        }

        public IEnumerable<TimeSpan> EnumTriggerPoints(TimeSpan start, TimeSpan end, int triggerChannel, int every)
        {
            int seen = 0;
            for (TimeSpan loc = start; loc < end; loc = loc + mainFile.PeriodLength) {
                if (loc.TotalMilliseconds > 0) {
                    TimeSpan prev = loc - mainFile.PeriodLength;
                    if (mainFile.GetData(triggerChannel, prev) == 0 && mainFile.GetData(triggerChannel, loc) >= 128) {
                        seen += 1;
                        if (seen == every) {
                            seen = 0;
                            yield return loc;
                        }
                    }
                }
            }
        }

        public void CopyTemplate(TimeSpan templateStart, TimeSpan templateEnd, TimeSpan templateAlign, TimeSpan location, int[] channelNumbers, bool merge)
        {
            if (template.PeriodLength != mainFile.PeriodLength || template.Channels > mainFile.Channels)
                throw new InvalidOperationException("Incompatible vixen files");

            TimeSpan destLoc = location - (templateAlign - templateStart);
            for (TimeSpan templateLoc = templateStart; templateLoc <= templateEnd; templateLoc = templateLoc + template.PeriodLength) {
                if (destLoc >= new TimeSpan(0) && destLoc < mainFile.TotalLength) {
                    foreach (int channel in channelNumbers) {
                        byte value = template.GetData(channel, templateLoc);
                        if (merge) {
                            byte current = mainFile.GetData(channel, destLoc);
                            mainFile.SetData(channel, destLoc, Math.Max(value, current));
                        }
                        else {
                            mainFile.SetData(channel, destLoc, value);
                        }
                    }

                    destLoc += mainFile.PeriodLength;
                }
            }
        }
    }
}
