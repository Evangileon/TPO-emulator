namespace TPO.TPOFile
{
    using System;
    using System.IO;

    internal class RTFReader
    {
        public static string getRTF(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

