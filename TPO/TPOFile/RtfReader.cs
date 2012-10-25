namespace TPO.TPOFile
{
    using System;
    using System.IO;

    internal class RtfReader
    {
        public static string getRTF(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch
            {
                return "";
            }
        }
    }
}

