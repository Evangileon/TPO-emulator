namespace TPO.Common
{
    using System;
    using System.Collections;
    using TPO.Utility;
    using System.Collections.Generic;


    /// <summary>
    /// 一场考试包含四个Part，一个Part包含二或三个Section，一个Section包含若干个Question
    /// Section是一个测试单元，包含一段题目（一篇文章，听力或者作文），和若干个问题(Question)
    /// </summary>
    public class Section : IEnumerable
    {
        #region 原来
        public int AnswerID;//no need
        public int TPONO;//no need
        public int Score;
        public ArrayList CorrectAnswer;
        public QuestionType QuestionType;  //no need

        public ArrayList MyAnswer;
              
        public string QuestionExplanation;
        public string QuestionTitle;
                 
        public ArrayList RowStrs = new ArrayList();
        public ArrayList ColStrs = new ArrayList();   
        #endregion 原来

        List<Question> Questions;
        private int timeLimitMin;

        public Section()
        {
            //this.ColStrs = new ArrayList();
            //this.RowStrs = new ArrayList();
            this.MyAnswer = new ArrayList();
            this.CorrectAnswer = new ArrayList();
        }

        public bool IsAnswered
        {
            get
            {
                int num = 0;
                for (int i = 0; i < this.MyAnswer.Count; i++)
                {
                    num += Convert.ToInt32(this.MyAnswer[i]);
                }
                return (num != 0);
            }
            //set;
        }

        public string CorrectAnswersStr
        {
            get
            {
                string str = "";
                for (int i = 0; i < this.CorrectAnswer.Count; i++)
                {
                    int num = Convert.ToInt32(this.CorrectAnswer[i]);
                    if (num > 0)
                    {
                        str = str + Convert.ToChar((int) (num + 0x40)).ToString();
                    }
                }
                return str;
            }
        }

        public string MyAnswersStr
        {
            get
            {
                string str = "";
                if (this.QuestionType == TPO.Utility.QuestionType.SUMMARY)
                {
                    this.MyAnswer.Sort();
                }
                for (int i = 0; i < this.MyAnswer.Count; i++)
                {
                    int num = (int) this.MyAnswer[i];
                    if (num > 0)
                    {
                        str = str + Convert.ToChar((int) (num + 0x40)).ToString();
                    }
                }
                return str;
            }
        }

        public int GetTimeLimitMin()
        {
            return this.timeLimitMin;
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

        public IEnumerator GetEnumerator()
        {
            foreach (Question q in Questions)
            {
                yield return q;
            }
        }
    }

    class ReadingSection : Section
    {
         
    }

    class ListeningSection : Section
    {
        public string MP3Path;
        public string RepeatMP3Path; 
    }

    class SpeakingSection : Section
    {
        public string MP3Path;
    }

    class WritingSection : Section
    {
        public string MP3Path;
    }
}

