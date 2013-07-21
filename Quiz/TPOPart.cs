namespace TPO.Quiz
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TPO.Common;
    using TPO.TPOFile;
    using TPO.Utility;

    public class TPOPart : IEnumerable
    {
        public int QuestionCount = 0;
        //public ArrayList Questions = new ArrayList();
        public List<TPOSection> Sections;

        private string filepath;

        private string rtfStr = "";

        public TPOPart(string rtfStr, string mp3XML, string explanationStr)
        {
            this.rtfStr = rtfStr;
            this.ExtractQuestions(mp3XML, explanationStr);
            this.Sections = new List<TPOSection>(3);
        }

        public TPOPart(string filepath)
        {
            this.filepath = filepath;
            var reader = new XMLReader(this.filepath);
            var sectionCount = int.Parse(reader.GetAttr("//@sectionCount"));

            for (int i = 0; i < sectionCount; i++)
            {
                var s = new TPOSection(filepath);
                this.Sections.Add(s);
            }
        }

        public void ExtractQuestions(string mp3XML, string explanationStr)
        {
            int num3;
            RichTextBox box = new RichTextBox();
            RichTextBox box2 = new RichTextBox();
            box.Rtf = this.rtfStr;
            string selectedRtf = "";
            string[] strArray = box.Text.Split(new string[] { "</Q>" }, StringSplitOptions.RemoveEmptyEntries);
            int num = 1;
            int num2 = 0;
            this.QuestionCount = strArray.Length;
            for (num3 = 0; num3 < strArray.Length; num3++)
            {
                num2 = strArray[num3].Length + 4;
                box.SelectionStart = num;
                box.SelectionLength = num2;
                selectedRtf = box.SelectedRtf;
                num += num2;
                box2.Rtf = selectedRtf;
                string[] strArray2 = box2.Text.Split(new char[] { '\n' });
                TPOSection section = new TPOSection();
                section.AnswerID = num3 + 1;
                section.MyAnswer = new ArrayList(strArray2.Length - 3);
                int num4 = 0;
                box2.SelectionStart = num4;
                box2.SelectionLength = strArray2[0].Length;
                num4 = (num4 + strArray2[0].Length) + 1;
                string[] strArray3 = box2.SelectedText.Split(new char[] { ',' });
                section.Score = Convert.ToInt16(strArray3[0]);
                section.QuestionType = (QuestionType) (Convert.ToInt16(strArray3[1]) - 1);
                int num5 = Convert.ToInt16(strArray3[2]);
                section.CorrectAnswer = new ArrayList(num5);
                for (int i = 0; i < num5; i++)
                {
                    section.CorrectAnswer[i] = Convert.ToInt16(strArray3[3 + i]);
                }
                box2.SelectionStart = num4;
                box2.SelectionLength = strArray2[1].Length;
                num4 = (num4 + strArray2[1].Length) + 1;
                section.QuestionTitle = box2.SelectedRtf;
                for (int j = 2; j < (strArray2.Length - 1); j++)
                {
                    box2.SelectionStart = num4;
                    box2.SelectionLength = strArray2[j].Length;
                    section.MyAnswer[j - 2] = box2.SelectedRtf;
                    num4 = (num4 + strArray2[j].Length) + 1;
                }
                if (section.QuestionType == QuestionType.TABLE)
                {
                    foreach (string my in section.MyAnswer)
                    {
                        string str5 = my;
                        if (str5.Contains("</C>"))
                        {
                            section.ColStrs.Add(str5.Replace("</C>", ""));
                        }
                        else if (str5.Contains("</R>"))
                        {
                            section.RowStrs.Add(str5.Replace("</R>", ""));
                        }
                    }
                }
                if (!mp3XML.Equals(""))
                {
                    int num9 = num3 + 1;
                    XMLReader reader = new XMLReader(mp3XML);
                    ListeningSection listen = (ListeningSection)section;
                    listen.MP3Path = reader.GetAttr("//question[@NO=" + num9 + "]/@Content");
                    listen.RepeatMP3Path = reader.GetAttr("//question[@NO=" + num9 + "]/@Repeat");
                }
                this.Sections.Add(section);
            }
            if ((explanationStr != null) && !explanationStr.Equals(""))
            {
                box.Rtf = explanationStr;
                string[] strArray4 = box.Text.Split(new string[] { "</Q>" }, StringSplitOptions.RemoveEmptyEntries);
                int num10 = 0;
                int num11 = 0;
                for (num3 = 0; (num3 < this.Sections.Count) && (num3 < strArray4.Length); num3++)
                {
                    num11 = strArray4[num3].Length + 4;
                    box.SelectionStart = num10;
                    box.SelectionLength = num11 - 4;
                    ((TPOSection) this.Sections[num3]).QuestionExplanation = box.SelectedRtf;
                    num10 += num11;
                }
            }
            box.Dispose();
            box2.Dispose();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (TPOSection s in Sections)
            {
                yield return s;
            }
        }
    }
}

