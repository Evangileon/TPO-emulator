namespace TPO.Common
{
    using System;
    using System.IO;
    using System.Security.Cryptography;

    internal class MD5Generate
    {
        public static string md5_hash(string path)
        {
            try
            {
                FileStream inputStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
                return BitConverter.ToString(provider.ComputeHash(inputStream)).Replace("-", "");
            }
            catch (Exception exception)
            {
                return exception.ToString();
            }
        }
    }
}

