using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question
    {
        public string QuestionText { get; }
        public string[] Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string qeustionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = qeustionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
