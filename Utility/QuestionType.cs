namespace TPO.Utility
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Collections;
    using System.Reflection;

    public enum QuestionType
    {
        SINGLE,
        MULTIPLE,
        INSERT,
        SUMMARY,
        TABLE,
        SORT
    }
/*
    internal class QuestionTypeString
    {
        Dictionary<QuestionType, string> dict = new Dictionary<QuestionType,string>{
            {QuestionType.SINGLE, "SINGLE"},
            {QuestionType.MULTIPLE, "MULTIPLE"},
            {QuestionType.INSERT, "INSERT"},
            {QuestionType.SUMMARY, "SUMMARY"},
            {QuestionType.SORT, "SORT"},
            {QuestionType.TABEL, "TABEL"}
        };

        Dictionary<string, QuestionType> dict2 = new Dictionary<string, QuestionType>{
            {"SINGLE", QuestionType.SINGLE},
            {"MULTIPLE", QuestionType.MULTIPLE},
            {"INSERT", QuestionType.INSERT},
            {"SUMMARY", QuestionType.SUMMARY},
            {"SORT", QuestionType.SORT},
            {"TABEL", QuestionType.TABEL}
        };        

        public static string ToString(QuestionType type)
        {
            //return dict[type];
            Type t = type.GetType()

            return null;
        }

        public static QuestionType ToQuestionType(string type)
        {
            return dict2[type];
        }
    }*/
}

