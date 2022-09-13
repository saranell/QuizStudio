using System;
namespace QuizStudio
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public int Score { get; set; }
        private int InitialPoints { get; set; }


        public Quiz(List<Question> questions)
        {
            Questions = questions;
            InitialPoints = 0;
            Score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                InitialPoints += questions[i].Points;
            }
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
            InitialPoints += question.Points;
        }

        public void RunQuiz()
        {
            foreach(Question question in Questions)
            {
                Console.WriteLine(question.QuestionText);
                question.DisplayAnswerChoices();
                question.GetUsersAnswers();

            }
        }
    }
}

