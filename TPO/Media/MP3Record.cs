namespace TPO.Media
{
    using System;
    using System.Runtime.InteropServices;

    internal class MP3Record
    {
        private string filePath;

        [DllImport("winmm.dll", EntryPoint="mciSendStringA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;
        }

        public void Start()
        {
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
        }

        public void Stop()
        {
            mciSendString("save recsound " + this.filePath, "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
        }
    }
}

