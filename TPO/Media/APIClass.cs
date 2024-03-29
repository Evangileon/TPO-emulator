﻿namespace TPO.Media
{
    using System;
    using System.Runtime.InteropServices;

    public class APIClass
    {
        [DllImport("kernel32.dll", CharSet=CharSet.Auto)]
        public static extern int GetShortPathName(string lpszLongPath, string shortFile, int cchBuffer);
        [DllImport("winmm.dll", CharSet=CharSet.Auto)]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
    }
}

