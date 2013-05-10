using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace TPO.Common
{
	public class Question
	{
        private string question;
        private ArrayList options;
        private ArrayList answers;
        
        public Question()
        {
            question = "";
            options = new ArrayList(4);
        }

        public Question(string questionStr)
        {
            this.question = questionStr;
            this.options = new ArrayList(4);
        }

        public void AddOption(String option)
        {
            this.options.Add(option);
        }

        public void AddAnswer(string answer)
        {
            this.answers.Add(answer);
        }

        public string GetQuestion()
        {
            return question;
        }

        ArrayList GetOptions()
        {
            return options;
        }

        ArrayList GetAnswers()
        {
            return answers;
        }

        public bool IsAnswered
        {
            get;
            set;
        }
	}

    class QuestionSingle : Question
    {
        
    }

    class QuestionMulti : Question
    {
        int AnsNumRequired;

    }

    class QuestionInsert : Question
    {

    }

    class QuestionSummary : Question
    {

    }

    class QuestionTable : Question
    {

    }

    class QuestionSort : Question
    {

    }
}
