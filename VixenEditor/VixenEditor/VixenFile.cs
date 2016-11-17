using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace VixenEditor
{
    internal class VixenFile
    {
        private string fileName;
        XmlDocument xmlDocument;
        TimeSpan totalLength, periodLength;
        byte[] data;

        public VixenFile(string fileName)
        {
            this.fileName = fileName;
            xmlDocument = new XmlDocument();
            xmlDocument.PreserveWhitespace = true;
            xmlDocument.Load(fileName);

            XmlNode node = xmlDocument.SelectSingleNode("/Program/Time");
            totalLength = TimeSpan.FromMilliseconds(XmlConvert.ToInt64(node.InnerText));

            node = xmlDocument.SelectSingleNode("/Program/EventPeriodInMilliseconds");
            periodLength = TimeSpan.FromMilliseconds(XmlConvert.ToInt64(node.InnerText));

            LoadData();
        }

        public string FileName
        {
            get { return fileName; }
        }

        public string BaseFileName
        {
            get { return Path.GetFileName(fileName); }
        }

        public TimeSpan TotalLength
        {
            get
            {
                return totalLength;
            }
        }

        public TimeSpan PeriodLength
        {
            get
            {
                return periodLength;
            }
        }

        public int NumberOfPeriods
        {
            get
            {
                return (int)Math.Round(TotalLength.TotalMilliseconds / PeriodLength.TotalMilliseconds);
            }
        }

        public int Channels
        {
            get { return data.Length / NumberOfPeriods; }
        }

        public byte GetData(int channel, TimeSpan time)
        {
            if (time >= TotalLength || time.TotalMilliseconds < 0) {
                throw new ArgumentException("Invalid time location", nameof(time));
            }
            if (channel < 1 || channel > Channels) {
                throw new ArgumentException("Invalid channel number", nameof(channel));
            }

            int period = (int) Math.Round(time.TotalMilliseconds / PeriodLength.TotalMilliseconds);
            return data[(channel - 1) * NumberOfPeriods + period];
        }

        public void SetData(int channel, TimeSpan time, byte value)
        {
            if (time >= TotalLength || time.TotalMilliseconds < 0) {
                throw new ArgumentException("Invalid time location", nameof(time));
            }
            if (channel < 1 || channel > Channels) {
                throw new ArgumentException("Invalid channel number", nameof(channel));
            }

            int period = (int)Math.Round(time.TotalMilliseconds / PeriodLength.TotalMilliseconds);
            data[(channel - 1) * NumberOfPeriods + period] = value;
        }

        public void Save(string fileName)
        {
            SaveData();
            xmlDocument.Save(fileName);
        }

        private void LoadData()
        {
            XmlNode node = xmlDocument.SelectSingleNode("/Program/EventValues");
            string eventValues = node.InnerText;
            data = Convert.FromBase64String(eventValues);
        }

        private void SaveData()
        {
            XmlNode node = xmlDocument.SelectSingleNode("/Program/EventValues");
            node.InnerText = Convert.ToBase64String(data);
        }
    }
}