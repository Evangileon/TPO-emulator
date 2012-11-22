namespace TPO.Common
{
    using System;
    using System.Collections;
    using TPO.Utility;

    internal class Question
    {
        public string[] Answers;
        public ArrayList ColStrs = new ArrayList();
        public int ID;
        public string MP3Path;
        public string QuestionExplanation;
        public string QuestionTitle;
        public TPO.Utility.QuestionType QuestionType;
        public string RepeatMP3Path;
        public int[] RightAnswers;
        public ArrayList RowStrs = new ArrayList();
        public int Score;
        public ArrayList UserAnswers = new ArrayList();

        public Question()
        {
            this.ColStrs = new ArrayList();
            this.RowStrs = new ArrayList();
            this.Answers = null;
            this.RightAnswers = null;
            this.UserAnswers = new ArrayList();
        }

        public bool IsAnswered
        {
            get
            {
                int num = 0;
                for (int i = 0; i < this.UserAnswers.Count; i++)
                {
                    num += (int) this.UserAnswers[i];
                }
                return (num != 0);
            }
        }

        public string RightAnswersStr
        {
            get
            {
                string str = "";
                for (int i = 0; i < this.RightAnswers.Length; i++)
                {
                    int num = this.RightAnswers[i];
                    if (num > 0)
                    {
                        str = str + Convert.ToChar((int) (num + 0x40)).ToString();
                    }
                }
                return str;
            }
        }

        public string UserAnswersStr
        {
            get
            {
                string str = "";
                if (this.QuestionType == TPO.Utility.QuestionType.SUMMARY)
                {
                    this.UserAnswers.Sort();
                }
                for (int i = 0; i < this.UserAnswers.Count; i++)
                {
                    int num = (int) this.UserAnswers[i];
                    if (num > 0)
                    {
                        str = str + Convert.ToChar((int) (num + 0x40)).ToString();
                    }
                }
                return str;
            }
        }

        //QuestionNo TEXT(5) PRIMARY KEY AUTOINCREMENT, QuestionType TEXT(15), YourAnswers TEXT(5), StandardAnswers TEXT(5), Score TEXT(5)
        public int QuestionNo
        {
            set;
            get;
        }
        public string QuesType
        {
            set
            {
                this.QuestionType = (QuestionType)Enum.Parse(typeof(QuestionType), value, true);
            }
            get
            {
                return this.QuestionType.ToString();
            }
        }
        public string YourAnswers
        {
            set;
            get;
        }
        public string StandardAnswers
        {
            set;
            get;
        }
        public int Scores
        {
            set;
            get;
        }
    }
}

