using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"  {i + 1}");
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }

        }

        private int GetUserChoice()
        {
            int answer;

            Console.Write("Your answer (number): ");
            while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
            }

            return answer - 1;
        }

        private void DisplayResult()
        {
            Console.WriteLine($"Quiz finished. Your score is {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            if (percentage > 0.8)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Excelent Work!");
            }
            else if (percentage > 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicig!");
            }
            Console.ResetColor();
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1;

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();

                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! the correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }

            DisplayResult();
        }
    }
}
