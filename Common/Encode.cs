namespace TPO.Common
{
    using System;
    using System.IO;
    using System.Management;
    using System.Security.Cryptography;
    using System.Text;

    internal class Encode
    {
        public string IV_64 = "&^!m@rd%";
        public string KEY_64 = "%-n+8*iL";

        public string Decode(string data)
        {
            byte[] buffer3;
            byte[] bytes = Encoding.ASCII.GetBytes(this.KEY_64);
            byte[] rgbIV = Encoding.ASCII.GetBytes(this.IV_64);
            try
            {
                buffer3 = Convert.FromBase64String(data);
            }
            catch
            {
                return null;
            }
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            MemoryStream stream = new MemoryStream(buffer3);
            CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(stream2);
            return reader.ReadToEnd();
        }

        public string Encoded(string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(this.KEY_64);
            byte[] rgbIV = Encoding.ASCII.GetBytes(this.IV_64);
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            int keySize = provider.KeySize;
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(stream2);
            writer.Write(data);
            writer.Flush();
            stream2.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(stream.GetBuffer(), 0, (int) stream.Length);
        }

        public string GetCPUID()
        {
            string str = string.Empty;
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject obj2 in searcher.Get())
                {
                    return obj2["Signature"].ToString().Replace(":", "");
                }
                return str;
            }
            catch
            {
            }
            return str;
        }

        public string GetHardDiskID()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
                string str = null;
                foreach (ManagementObject obj2 in searcher.Get())
                {
                    str = obj2["Version"].ToString().Trim();
                    break;
                }
                return str;
            }
            catch
            {
                return "";
            }
        }

        public string GetSHA1MachineCode(string code)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(code);
            return BitConverter.ToString(SHA1.Create().ComputeHash(bytes)).Replace("-", "");
        }
    }
}

