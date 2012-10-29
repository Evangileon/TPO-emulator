namespace TPO.UI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;
    using TPO.Common;
    using TPO.TPOFile;

    public class File2Acces : Form
    {
        private Button btn_execute;
        private Button btn_execute2;
        private Button btn_exp;
        private Button btn_md5;
        private IContainer components = null;

        public File2Acces()
        {
            this.InitializeComponent();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            LyricsReader reader = new LyricsReader();
            int num = 1;
            for (num = 1; num < 0x19; num++)
            {
                Random random;
                Exception exception;
                Stream stream = null;
                StreamReader reader2 = null;
                string str = "";
                string str2 = "";
                try
                {
                    stream = File.Open(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-conversation1.lrc", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    reader2 = new StreamReader(stream, Encoding.GetEncoding("gb2312"));
                    random = null;
                    while (!reader2.EndOfStream)
                    {
                        str2 = reader2.ReadLine() + "\r\n";
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(0, 2) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(2, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(3, 1) + "1" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(4, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(5, 2) + "2" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(7, 2) + "0" + random.Next(0, 9).ToString();
                        str = str + str2.Substring(9);
                    }
                    reader2.Close();
                    stream.Close();
                }
                catch
                {
                    reader2.Close();
                    stream.Close();
                }
                FileStream stream2 = null;
                StreamWriter writer = null;
                try
                {
                    stream2 = new FileStream(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-conversation1.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream2);
                    str.Replace("‘", "'");
                    str.Replace("—", "---");
                    str.Replace("…", "...");
                    str.Replace("“", "\"");
                    str.Replace("”", "\"");
                    writer.Write(string.Format("{0}", str.Replace("’", "'")));
                }
                catch (Exception exception1)
                {
                    exception = exception1;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
                str = "";
                str2 = "";
                try
                {
                    stream = File.Open(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-conversation2.lrc", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    reader2 = new StreamReader(stream, Encoding.GetEncoding("gb2312"));
                    random = null;
                    while (!reader2.EndOfStream)
                    {
                        str2 = reader2.ReadLine() + "\r\n";
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(0, 2) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(2, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(3, 1) + "1" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(4, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(5, 2) + "2" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(7, 2) + "0" + random.Next(0, 9).ToString();
                        str = str + str2.Substring(9);
                    }
                    reader2.Close();
                    stream.Close();
                }
                catch
                {
                    reader2.Close();
                    stream.Close();
                }
                stream2 = null;
                writer = null;
                try
                {
                    stream2 = new FileStream(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-conversation2.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream2);
                    str.Replace("‘", "'");
                    str.Replace("—", "---");
                    str.Replace("…", "...");
                    str.Replace("“", "\"");
                    str.Replace("”", "\"");
                    writer.Write(string.Format("{0}", str.Replace("’", "'")));
                }
                catch (Exception exception2)
                {
                    exception = exception2;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
                str = "";
                str2 = "";
                try
                {
                    stream = File.Open(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-lecture1.lrc", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    reader2 = new StreamReader(stream, Encoding.GetEncoding("gb2312"));
                    random = null;
                    while (!reader2.EndOfStream)
                    {
                        str2 = reader2.ReadLine() + "\r\n";
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(0, 2) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(2, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(3, 1) + "1" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(4, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(5, 2) + "2" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(7, 2) + "0" + random.Next(0, 9).ToString();
                        str = str + str2.Substring(9);
                    }
                    reader2.Close();
                    stream.Close();
                }
                catch
                {
                    reader2.Close();
                    stream.Close();
                }
                stream2 = null;
                writer = null;
                try
                {
                    stream2 = new FileStream(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-lecture1.txt", FileMode.Create, FileAccess.Write);
                    str.Replace("‘", "'");
                    str.Replace("—", "---");
                    str.Replace("…", "...");
                    str.Replace("“", "\"");
                    str.Replace("”", "\"");
                    writer = new StreamWriter(stream2);
                    writer.Write(string.Format("{0}", str.Replace("’", "'")));
                }
                catch (Exception exception3)
                {
                    exception = exception3;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
                str = "";
                str2 = "";
                try
                {
                    stream = File.Open(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-lecture2.lrc", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    reader2 = new StreamReader(stream, Encoding.GetEncoding("gb2312"));
                    random = null;
                    while (!reader2.EndOfStream)
                    {
                        str2 = reader2.ReadLine() + "\r\n";
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(0, 2) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(2, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(3, 1) + "1" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(4, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(5, 2) + "2" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(7, 2) + "0" + random.Next(0, 9).ToString();
                        str = str + str2.Substring(9);
                    }
                    reader2.Close();
                    stream.Close();
                }
                catch
                {
                    reader2.Close();
                    stream.Close();
                }
                stream2 = null;
                writer = null;
                try
                {
                    stream2 = new FileStream(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-lecture2.txt", FileMode.Create, FileAccess.Write);
                    str.Replace("‘", "'");
                    str.Replace("—", "---");
                    str.Replace("…", "...");
                    str.Replace("“", "\"");
                    str.Replace("”", "\"");
                    writer = new StreamWriter(stream2);
                    writer.Write(string.Format("{0}", str.Replace("’", "'")));
                }
                catch (Exception exception4)
                {
                    exception = exception4;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
                str = "";
                str2 = "";
                try
                {
                    stream = File.Open(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-lecture3.lrc", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    reader2 = new StreamReader(stream, Encoding.GetEncoding("gb2312"));
                    random = null;
                    while (!reader2.EndOfStream)
                    {
                        str2 = reader2.ReadLine() + "\r\n";
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(0, 2) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(2, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(3, 1) + "1" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(4, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(5, 2) + "2" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(7, 2) + "0" + random.Next(0, 9).ToString();
                        str = str + str2.Substring(9);
                    }
                    reader2.Close();
                    stream.Close();
                }
                catch
                {
                    reader2.Close();
                    stream.Close();
                }
                stream2 = null;
                writer = null;
                try
                {
                    stream2 = new FileStream(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-lecture3.txt", FileMode.Create, FileAccess.Write);
                    str.Replace("‘", "'");
                    str.Replace("—", "---");
                    str.Replace("…", "...");
                    str.Replace("“", "\"");
                    str.Replace("”", "\"");
                    writer = new StreamWriter(stream2);
                    writer.Write(string.Format("{0}", str.Replace("’", "'")));
                }
                catch (Exception exception5)
                {
                    exception = exception5;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
                str = "";
                str2 = "";
                try
                {
                    stream = File.Open(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-lecture4.lrc", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    reader2 = new StreamReader(stream, Encoding.GetEncoding("gb2312"));
                    random = null;
                    while (!reader2.EndOfStream)
                    {
                        str2 = reader2.ReadLine() + "\r\n";
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(0, 2) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(2, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(3, 1) + "1" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(4, 1) + "0" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(5, 2) + "2" + random.Next(0, 9).ToString();
                        random = new Random(GetRandomSeed());
                        str = str + str2.Substring(7, 2) + "0" + random.Next(0, 9).ToString();
                        str = str + str2.Substring(9);
                    }
                    reader2.Close();
                    stream.Close();
                }
                catch
                {
                    reader2.Close();
                    stream.Close();
                }
                stream2 = null;
                writer = null;
                try
                {
                    stream2 = new FileStream(@"Tests\" + num.ToString() + @"\Listening\tpo" + num.ToString() + "-lecture4.txt", FileMode.Create, FileAccess.Write);
                    str.Replace("‘", "'");
                    str.Replace("—", "---");
                    str.Replace("…", "...");
                    str.Replace("“", "\"");
                    str.Replace("”", "\"");
                    writer = new StreamWriter(stream2);
                    writer.Write(string.Format("{0}", str.Replace("’", "'")));
                }
                catch (Exception exception6)
                {
                    exception = exception6;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
            }
        }

        private void btn_execute2_Click(object sender, EventArgs e)
        {
            int num = 0;
            for (num = 1; num < 0x19; num++)
            {
                Exception exception;
                string str = RtfReader.getRTF(@"Tests\" + num.ToString() + @"\Reading\1.rtf");
                string str2 = RtfReader.getRTF(@"Tests\" + num.ToString() + @"\Reading\2.rtf");
                string str3 = RtfReader.getRTF(@"Tests\" + num.ToString() + @"\Reading\Questions1.rtf");
                string str4 = RtfReader.getRTF(@"Tests\" + num.ToString() + @"\Reading\Questions2.rtf");
                str = str.Substring(0, 0xb5) + str;
                str2 = str.Substring(0, 0xb5) + str2;
                str3 = str.Substring(0, 0xb5) + str3;
                str4 = str.Substring(0, 0xb5) + str4;
                FileStream stream = null;
                StreamWriter writer = null;
                try
                {
                    stream = new FileStream(@"Tests\" + num.ToString() + @"\Reading\1.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream);
                    writer.Write(string.Format("{0}", str));
                }
                catch (Exception exception1)
                {
                    exception = exception1;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
                try
                {
                    stream = new FileStream(@"Tests\" + num.ToString() + @"\Reading\2.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream);
                    writer.Write(string.Format("{0}", str2));
                }
                catch (Exception exception2)
                {
                    exception = exception2;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
                try
                {
                    stream = new FileStream(@"Tests\" + num.ToString() + @"\Reading\questions1.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream);
                    writer.Write(string.Format("{0}", str3));
                }
                catch (Exception exception3)
                {
                    exception = exception3;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
                try
                {
                    stream = new FileStream(@"Tests\" + num.ToString() + @"\Reading\questions2.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream);
                    writer.Write(string.Format("{0}", str4));
                }
                catch (Exception exception4)
                {
                    exception = exception4;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            int num = 0;
            for (num = 1; num < 0x19; num++)
            {
                Exception exception;
                string str = RtfReader.getRTF(@"Explanations\" + num.ToString() + @"\Reading\P1.rtf");
                string str2 = RtfReader.getRTF(@"Explanations\" + num.ToString() + @"\Reading\P2.rtf");
                string str3 = RtfReader.getRTF(@"Explanations\" + num.ToString() + @"\Reading\Q1.rtf");
                string str4 = RtfReader.getRTF(@"Explanations\" + num.ToString() + @"\Reading\Q2.rtf");
                str = str.Substring(0, 0xb5) + str;
                str2 = str.Substring(0, 0xb5) + str2;
                str3 = str.Substring(0, 0xb5) + str3;
                str4 = str.Substring(0, 0xb5) + str4;
                FileStream stream = null;
                StreamWriter writer = null;
                try
                {
                    stream = new FileStream(@"Explanations\" + num.ToString() + @"\Reading\P1.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream);
                    writer.Write(string.Format("{0}", str));
                }
                catch (Exception exception1)
                {
                    exception = exception1;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
                try
                {
                    stream = new FileStream(@"Explanations\" + num.ToString() + @"\Reading\P2.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream);
                    writer.Write(string.Format("{0}", str2));
                }
                catch (Exception exception2)
                {
                    exception = exception2;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
                try
                {
                    stream = new FileStream(@"Explanations\" + num.ToString() + @"\Reading\Q1.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream);
                    writer.Write(string.Format("{0}", str3));
                }
                catch (Exception exception3)
                {
                    exception = exception3;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
                try
                {
                    stream = new FileStream(@"Explanations\" + num.ToString() + @"\Reading\Q2.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream);
                    writer.Write(string.Format("{0}", str4));
                }
                catch (Exception exception4)
                {
                    exception = exception4;
                    MessageBox.Show(exception.StackTrace);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void btn_md5_Click(object sender, EventArgs e)
        {
            FileStream stream = null;
            StreamWriter writer = null;
            string str = "";
            string str2 = "RMD5 = {\"\",";
            string str3 = "LMD5 = {\"\",";
            string str4 = "SMD5 = {\"\",";
            string str5 = "WMD5 = {\"\",";
            try
            {
                stream = new FileStream("MD5.txt", FileMode.Create, FileAccess.Write);
                for (int i = 1; i < 0x19; i++)
                {
                    str2 = str2 + "\"" + MD5Generate.md5_hash(@"Tests\" + i.ToString() + @"\Reading\1.txt") + "\",\n";
                    str3 = str3 + "\"" + MD5Generate.md5_hash(@"Tests\" + i.ToString() + @"\Listening\questions.rtf") + "\",\n";
                    str4 = str4 + "\"" + MD5Generate.md5_hash(@"Tests\" + i.ToString() + @"\speaking\questions.rtf") + "\",\n";
                    str5 = str5 + "\"" + MD5Generate.md5_hash(@"Tests\" + i.ToString() + @"\writing\Speech.mp3") + "\",\n";
                }
                str = str2 + "}\n\n" + str3 + "}\n\n" + str4 + "}\n\n" + str5 + "}\n\n";
                writer = new StreamWriter(stream);
                writer.Write(string.Format("{0}", str));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private static int GetRandomSeed()
        {
            byte[] data = new byte[4];
            new RNGCryptoServiceProvider().GetBytes(data);
            return BitConverter.ToInt32(data, 0);
        }

        private void InitializeComponent()
        {
            this.btn_execute = new Button();
            this.btn_execute2 = new Button();
            this.btn_md5 = new Button();
            this.btn_exp = new Button();
            base.SuspendLayout();
            this.btn_execute.Location = new Point(30, 12);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new Size(0xc2, 0x17);
            this.btn_execute.TabIndex = 0;
            this.btn_execute.Text = "Execute Listening";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new EventHandler(this.btn_execute_Click);
            this.btn_execute2.Location = new Point(30, 0x37);
            this.btn_execute2.Name = "btn_execute2";
            this.btn_execute2.Size = new Size(0xc2, 0x17);
            this.btn_execute2.TabIndex = 0;
            this.btn_execute2.Text = "Execute Reading";
            this.btn_execute2.UseVisualStyleBackColor = true;
            this.btn_execute2.Click += new EventHandler(this.btn_execute2_Click);
            this.btn_md5.Location = new Point(30, 0x67);
            this.btn_md5.Name = "btn_md5";
            this.btn_md5.Size = new Size(0xc2, 0x17);
            this.btn_md5.TabIndex = 1;
            this.btn_md5.Text = "Generate MD5";
            this.btn_md5.UseVisualStyleBackColor = true;
            this.btn_md5.Click += new EventHandler(this.btn_md5_Click);
            this.btn_exp.Location = new Point(30, 0x8f);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new Size(0xc2, 0x17);
            this.btn_exp.TabIndex = 2;
            this.btn_exp.Text = "Explanation";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new EventHandler(this.btn_exp_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x1e7, 230);
            base.Controls.Add(this.btn_exp);
            base.Controls.Add(this.btn_md5);
            base.Controls.Add(this.btn_execute2);
            base.Controls.Add(this.btn_execute);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.Name = "File2Acces";
            this.Text = "File2Acces";
            base.ResumeLayout(false);
        }
    }
}

