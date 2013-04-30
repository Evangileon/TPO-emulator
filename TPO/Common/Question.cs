using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace TPO.Common
{
	class Question
	{
        private string question;
        private ArrayList options;

        public Question(string questionStr)
        {
            this.question = questionStr;
            this.options = new ArrayList(4);
        }

        public void AddOption(String option)
        {
            this.options.Add(option);
        }

        public string GetQuestion()
        {
            return question;
        }

        ArrayList GetOptions()
        {
            return options;
        }
	}

    class QuestionSingle : Question
    {
        
    }

    class QuestionMulti : Question
    {

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
