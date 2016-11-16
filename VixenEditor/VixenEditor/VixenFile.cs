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
        byte[] data;

        public VixenFile(string fileName)
        {
            this.fileName = fileName;
            xmlDocument = new XmlDocument();
            xmlDocument.PreserveWhitespace = true;
            xmlDocument.Load(fileName);

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
                XmlNode node = xmlDocument.SelectSingleNode("/Program/Time");
                return TimeSpan.FromMilliseconds(XmlConvert.ToInt64(node.InnerText));
            }
        }

        public TimeSpan PeriodLength
        {
            get
            {
                XmlNode node = xmlDocument.SelectSingleNode("/Program/EventPeriodInMilliseconds");
                return TimeSpan.FromMilliseconds(XmlConvert.ToInt64(node.InnerText));
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

        private void LoadData()
        {
            XmlNode node = xmlDocument.SelectSingleNode("/Program/EventValues");
            string eventValues = node.InnerText;
            data = Convert.FromBase64String(eventValues);
        }



    }
}