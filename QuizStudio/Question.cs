using System;
namespace QuizStudio
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public int PointValue { get; set; }

        public Question(string questionText, int pointValue)
        {
            QuestionText = questionText;
            PointValue = pointValue;
        }

        public abstract void DisplayAnswerChoices();

        public abstract int GetUsersAnswers();
        
    }
    
}

