namespace TPO.TPOFile
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class LyricsReader
    {
        public ArrayList LrcList = new ArrayList();

        public string ReadLRCFile(string filePath)
        {
            Stream stream = null;
            StreamReader reader = null;
            string str = "";
            string strInput = "";
            try
            {
                stream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                reader = new StreamReader(stream, Encoding.GetEncoding("gb2312"));
                this.LrcList.Clear();
                while (!reader.EndOfStream)
                {
                    strInput = reader.ReadLine() + "\r\n";
                    str = str + this.regLrc(strInput);
                }
                reader.Close();
                stream.Close();
            }
            catch
            {
                reader.Close();
                stream.Close();
            }
            return str;
        }

        public string regLrc(string strInput)
        {
            string str = "";
            string str2 = "";
            string pattern = "(?<t>\\[\\d.*\\]+)(?<w>[^\\[]+\r\n)";
            Regex regex = new Regex(pattern);
            foreach (Match match in regex.Matches(strInput))
            {
                str = str + match.Groups["t"].ToString();
                string str4 = str.Substring(1, 1) + str.Substring(4, 1);
                string str5 = str.Substring(10, 1) + str.Substring(13, 2) + str.Substring(0x11, 2);
                int num = (int) ((Convert.ToDouble(str4) * 60000.0) + (Convert.ToDouble(str5) * 1000.0));
                str2 = str2 + match.Value.Substring(0x16, match.Value.Length - 0x18);
                if (str2 != "")
                {
                    this.LrcList.Add(new Lrc(num, str2));
                }
            }
            return str2;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Lrc
        {
            public int iTime;
            public string sText;
            public Lrc(int _sTime, string _sText)
            {
                this.iTime = _sTime;
                this.sText = _sText;
            }

            public override string ToString()
            {
                return (this.iTime.ToString() + " " + this.sText);
            }
        }
    }
}

