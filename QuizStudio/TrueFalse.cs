using System;
namespace QuizStudio
{
    public class TrueFalse : Question
    {
        private bool CorrectAnswer { get; set; }

        public TrueFalse(int pointValue, string questionText, bool correctAnswer) :base(questionText, pointValue)
        {
            PointValue = 1;
            CorrectAnswer = correctAnswer;  
        }
        
        public bool IsCorrectAnswer(bool possibleAnswer)
        {
            if (possibleAnswer == CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void DisplayAnswerChoices()
        {
            Console.WriteLine("True or False");
        }

        public override int GetUsersAnswers()
        {
            Console.WriteLine("Please enter 'T' for true & 'F' for false.");
            string userAnswer = Console.ReadLine();
            if (userAnswer.IndexOf("T") >= 0)
            {
                if (IsCorrectAnswer(true))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (IsCorrectAnswer(false))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

