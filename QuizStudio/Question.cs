using System;
namespace QuizStudio
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public int Points { get; set; }

        public Question(string questionText, int points)
        {
            QuestionText = questionText;
            Points = points;
        }

        public abstract void DisplayAnswerChoices();//displays the possible answers

        public abstract int GetUsersAnswers();
        
    }
    
}

