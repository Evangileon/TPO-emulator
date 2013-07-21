using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace TPO.Quiz
{
	public class TPOQuestion
	{
        private string question;
        private ArrayList options;
        private ArrayList answers;
        
        public TPOQuestion()
        {
            question = "";
            options = new ArrayList(4);
        }

        public TPOQuestion(string filepath)
        {
            //this.question = questionStr;
            //this.options = new ArrayList(4);
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

    class QuestionSingle : TPOQuestion
    {
        
    }

    class QuestionMulti : TPOQuestion
    {
        int AnsNumRequired;

    }

    class QuestionInsert : TPOQuestion
    {

    }

    class QuestionSummary : TPOQuestion
    {

    }

    class QuestionTable : TPOQuestion
    {

    }

    class QuestionSort : TPOQuestion
    {

    }
}
