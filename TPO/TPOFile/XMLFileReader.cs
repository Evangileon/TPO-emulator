namespace TPO.TPOFile
{
    using System;
    using System.Xml;

    internal class XMLFileReader
    {
        private string path;

        public XMLFileReader()
        {
        }

        public XMLFileReader(string path)
        {
            this.path = path;
        }

        public string GetAttr(string xpath)
        {
            string str = "";
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(this.path);
                str = document.SelectSingleNode(xpath).Value;
            }
            catch
            {
            }
            return str;
        }
    }
}

