namespace TPO.Media
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    internal class MP3MCI
    {
        [MarshalAs(UnmanagedType.LPTStr)]
        private string FilePath = "";
        private int ilong;
        public structMCI mc = new structMCI();
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=260)]
        private string Name = "";
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x80)]
        private string ReturnString = "";

        private string GetCurrPath(string name)
        {
            if (name.Length < 1)
            {
                return "";
            }
            name = name.Trim();
            name = name.Substring(0, name.Length - 1);
            return name;
        }

        public void play()
        {
            this.FilePath = "";
            this.FilePath = this.FilePath.PadLeft(0x7f, Convert.ToChar(" "));
            APIClass.mciSendString("play media", this.FilePath, this.FilePath.Length, 0);
            this.mc.state = State.mPlaying;
        }

        public void Puase()
        {
            this.FilePath = "";
            this.FilePath = this.FilePath.PadLeft(0x80, Convert.ToChar(" "));
            this.ilong = APIClass.mciSendString("pause media", this.FilePath, this.FilePath.Length, 0);
            this.mc.state = State.mPuase;
        }

        public void SetPlayTime(long lPosition)
        {
            this.FilePath = "";
            this.FilePath = this.FilePath.PadLeft(0x80, Convert.ToChar(" "));
            APIClass.mciSendString("seek media to " + lPosition.ToString(), this.FilePath, 0x80, 0);
            APIClass.mciSendString("play media", this.FilePath, this.FilePath.Length, 0);
        }

        public void SetVolume(string vol)
        {
            APIClass.mciSendString("setaudio media volume to " + vol, this.FilePath, 0x80, 0);
        }

        public void StopT()
        {
            this.FilePath = "";
            this.FilePath = this.FilePath.PadLeft(0x80, Convert.ToChar(" "));
            this.ilong = APIClass.mciSendString("close media", this.FilePath, 0x80, 0);
            this.ilong = APIClass.mciSendString("close all", this.FilePath, 0x80, 0);
            this.mc.state = State.mStop;
        }

        public int CurrentPosition
        {
            get
            {
                this.ReturnString = "";
                this.ReturnString = this.ReturnString.PadLeft(0x80, Convert.ToChar(" "));
                APIClass.mciSendString("status media position", this.ReturnString, this.ReturnString.Length, 0);
                this.ReturnString = this.ReturnString.Trim();
                this.ReturnString = this.ReturnString.Substring(0, this.ReturnString.Length - 1);
                if (this.ReturnString != "")
                {
                    this.mc.iPos = (int) (Convert.ToDouble(this.ReturnString) / 1000.0);
                }
                return this.mc.iPos;
            }
        }

        public string CurrentPosStr
        {
            get
            {
                this.ReturnString = "";
                this.ReturnString = this.ReturnString.PadLeft(0x80, Convert.ToChar(" "));
                APIClass.mciSendString("status media position", this.ReturnString, this.ReturnString.Length, 0);
                this.ReturnString = this.ReturnString.Trim();
                int num = (int) (Convert.ToDouble(this.ReturnString) / 1000.0);
                int num2 = num / 60;
                num = num % 60;
                string str = num2.ToString();
                string str2 = num.ToString();
                if ((num2 / 10) < 1)
                {
                    str = "0" + str;
                }
                if ((num / 10) < 1)
                {
                    str2 = "0" + str2;
                }
                return (str + ":" + str2);
            }
        }

        public int Duration
        {
            get
            {
                this.ReturnString = "";
                this.ReturnString = this.ReturnString.PadLeft(0x80, Convert.ToChar(" "));
                APIClass.mciSendString("status media length", this.ReturnString, this.ReturnString.Length, 0);
                this.ReturnString = this.ReturnString.Trim();
                if (this.ReturnString == "")
                {
                    return 0;
                }
                return (int) (Convert.ToDouble(this.ReturnString) / 1000.0);
            }
        }

        public int DurationMS
        {
            get
            {
                this.ReturnString = "";
                this.ReturnString = this.ReturnString.PadLeft(0x80, Convert.ToChar(" "));
                APIClass.mciSendString("status media length", this.ReturnString, this.ReturnString.Length, 0);
                this.ReturnString = this.ReturnString.Trim();
                if (this.ReturnString == "")
                {
                    return 0;
                }
                return (int) Convert.ToDouble(this.ReturnString);
            }
        }

        public string DurationStr
        {
            get
            {
                this.ReturnString = "";
                this.ReturnString = this.ReturnString.PadLeft(0x80, Convert.ToChar(" "));
                APIClass.mciSendString("status media length", this.ReturnString, this.ReturnString.Length, 0);
                this.ReturnString = this.ReturnString.Trim();
                int num = (int) (Convert.ToDouble(this.ReturnString) / 1000.0);
                int num2 = num / 60;
                num = num % 60;
                string str = num2.ToString();
                string str2 = num.ToString();
                if ((num2 / 10) < 1)
                {
                    str = "0" + str;
                }
                if ((num / 10) < 1)
                {
                    str2 = "0" + str2;
                }
                return (str + ":" + str2);
            }
        }

        public string FileName
        {
            get
            {
                return this.mc.iName;
            }
            set
            {
                try
                {
                    this.FilePath = "";
                    this.FilePath = this.FilePath.PadLeft(0x7f, Convert.ToChar(" "));
                    this.Name = this.Name.PadLeft(260, Convert.ToChar(" "));
                    this.mc.iName = value;
                    this.ilong = APIClass.GetShortPathName(this.mc.iName, this.Name, this.Name.Length);
                    this.Name = this.GetCurrPath(this.Name);
                    this.Name = string.Concat(new object[] { "open ", Convert.ToChar(0x22), this.Name, Convert.ToChar(0x22), " alias media" });
                    this.ilong = APIClass.mciSendString("close all", this.FilePath, this.FilePath.Length, 0);
                    this.ilong = APIClass.mciSendString(this.Name, this.FilePath, this.FilePath.Length, 0);
                    this.ilong = APIClass.mciSendString("set media time format milliseconds", this.FilePath, this.FilePath.Length, 0);
                    this.mc.state = State.mStop;
                }
                catch
                {
                    MessageBox.Show("Filename出错错误!");
                }
            }
        }

        public enum State
        {
            mPlaying = 1,
            mPuase = 2,
            mStop = 3
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct structMCI
        {
            public bool bMut;
            public int iDur;
            public int iPos;
            public int iVol;
            public int iBal;
            public string iName;
            public MP3MCI.State state;
        }
    }
}

