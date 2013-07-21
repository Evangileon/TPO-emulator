namespace TPO.Quiz
{
    using System;
    using System.Windows.Forms;
    using TPO.Utility;
    using System.Collections.Generic;
    using System.Collections;

    internal class TPOPassage : IEnumerable
    {
        public string FullRTF;
        public string FullTranslation;
        public string MP3Path;
        public int QuestionCount;
        public string Translation;

        List<TPOQuestion> Questions;

        public TPOPassage(string fullRTF, string translation)
        {
            this.FullRTF = fullRTF;
            this.FullTranslation = translation;
        }

        public TPOPassage(string filepath)
        {
            
        }

        public string ReadingPassageONQuestion(int questionNO, int spiltQuestionNO)
        {
            RichTextBox box = new RichTextBox();
            if (spiltQuestionNO != 0)
            {
                string text;
                string str2;
                RichTextBox box2 = new RichTextBox();
                int num = 0;
                int index = 0;
                if (questionNO <= spiltQuestionNO)
                {
                    box2.Rtf = this.FullRTF;
                    text = box2.Text;
                    num = text.IndexOf("<PASSAGE1>") + 10;
                    index = text.IndexOf("</PASSAGE1>");
                    box2.SelectionStart = num;
                    box2.SelectionLength = index - num;
                    box.Rtf = box2.SelectedRtf;
                    box2.Rtf = this.FullTranslation;
                    str2 = box2.Text;
                    num = str2.IndexOf("<TRANSLATION1>") + 14;
                    index = str2.IndexOf("</TRANSLATION1>");
                    box2.SelectionStart = num;
                    box2.SelectionLength = index - num;
                    this.Translation = box2.SelectedRtf;
                }
                else
                {
                    box2.Rtf = this.FullRTF;
                    text = box2.Text;
                    num = text.IndexOf("<PASSAGE2>") + 10;
                    index = text.IndexOf("</PASSAGE2>");
                    box2.SelectionStart = num;
                    box2.SelectionLength = index - num;
                    box.Rtf = box2.SelectedRtf;
                    box2.Rtf = this.FullTranslation;
                    str2 = box2.Text;
                    num = str2.IndexOf("<TRANSLATION2>") + 14;
                    index = str2.IndexOf("</TRANSLATION2>");
                    box2.SelectionStart = num;
                    box2.SelectionLength = index - num;
                    this.Translation = box2.SelectedRtf;
                }
            }
            else
            {
                box.Rtf = this.FullRTF;
                this.Translation = this.FullTranslation;
            }
            for (int i = 1; i < ConstantValues.MAXQUESTIONCOUNT; i++)
            {
                string str3;
                string str4;
                int num4;
                int num5;
                if (i == questionNO)
                {
                    str3 = "<" + i.ToString() + ">";
                    str4 = "</" + i.ToString() + ">";
                    num4 = box.Text.IndexOf(str3);
                    num5 = box.Text.IndexOf(str4);
                    RichTextBox box3 = new RichTextBox();
                    while ((num4 >= 0) && (num5 >= 0))
                    {
                        box.SelectionStart = num4;
                        box.SelectionLength = str3.Length;
                        box.Cut();
                        box.SelectedRtf = "";
                        box.SelectionStart = num5 - str3.Length;
                        box.SelectionLength = str4.Length;
                        box.Cut();
                        box.SelectedRtf = "";
                        num4 = box.Text.IndexOf(str3);
                        num5 = box.Text.IndexOf(str4);
                    }
                    str3 = "[" + i.ToString() + "]";
                    str4 = "[/" + i.ToString() + "]";
                    num4 = box.Text.IndexOf(str3);
                    num5 = box.Text.IndexOf(str4);
                    if (num4 >= 0)
                    {
                        box.SelectionStart = num4;
                        box.SelectionLength = str3.Length;
                        box.Cut();
                        box.SelectedRtf = "";
                    }
                    if (num5 >= 0)
                    {
                        box.SelectionStart = num5 - str3.Length;
                        box.SelectionLength = str4.Length;
                        box.Cut();
                        box.SelectedRtf = "";
                    }
                    str3 = "{" + i.ToString() + "}";
                    str4 = "{/" + i.ToString() + "}";
                    num4 = box.Text.IndexOf(str3);
                    num5 = box.Text.IndexOf(str4);
                    while ((num4 >= 0) || (num5 >= 0))
                    {
                        if (num4 >= 0)
                        {
                            box.SelectionStart = num4;
                            box.SelectionLength = str3.Length;
                            box.Cut();
                            box.SelectedRtf = "";
                        }
                        if (num5 >= 0)
                        {
                            box.SelectionStart = num5 - str3.Length;
                            box.SelectionLength = str4.Length;
                            box.Cut();
                            box.SelectedRtf = "";
                        }
                        num4 = box.Text.IndexOf(str3);
                        num5 = box.Text.IndexOf(str4);
                    }
                }
                else
                {
                    string str5 = "<" + i.ToString() + ">◆</" + i.ToString() + ">";
                    int num6 = box.Text.IndexOf(str5);
                    while (num6 >= 0)
                    {
                        box.SelectionStart = num6;
                        box.SelectionLength = str5.Length;
                        box.Cut();
                        box.SelectedRtf = "";
                        num6 = box.Text.IndexOf(str5);
                    }
                    str5 = "{" + i.ToString() + "}█{/" + i.ToString() + "}";
                    for (num6 = box.Text.IndexOf(str5); num6 >= 0; num6 = box.Text.IndexOf(str5))
                    {
                        box.SelectionStart = num6;
                        box.SelectionLength = str5.Length;
                        box.Cut();
                        box.SelectedRtf = "";
                    }
                    str3 = "[" + i.ToString() + "]";
                    str4 = "[/" + i.ToString() + "]";
                    num4 = box.Text.IndexOf(str3);
                    num5 = box.Text.IndexOf(str4);
                    if (num4 >= 0)
                    {
                        box.SelectionStart = num4;
                        box.SelectionLength = str3.Length;
                        box.Cut();
                        box.SelectedRtf = "";
                    }
                    if (num5 >= 0)
                    {
                        box.SelectionStart = num5 - str3.Length;
                        box.SelectionLength = str4.Length;
                        box.Cut();
                        box.SelectedRtf = "";
                    }
                    if (num5 > num4)
                    {
                        box.SelectionStart = num4 - 1;
                        box.SelectionLength = ((num5 - num4) - str3.Length) + 2;
                        string selectedText = box.SelectedText;
                        box.SelectedText = selectedText;
                    }
                }
            }
            string rtf = box.Rtf;
            box.Dispose();
            return rtf;
        }

        public IEnumerator GetEnumerator()
        {
            foreach(TPOQuestion q in Questions)
            {
                yield return q;
            }
        }
    }
}

