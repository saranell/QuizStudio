using System;
namespace QuizStudio
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public int Score { get; set; }
        private int Total { get; set; }


        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Total = 0;
            Score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                Total += questions[i].PointValue;
            }
        }

        public void AddQuestion(Question newQuestion)
        {
            Questions.Add(newQuestion);
            Total += newQuestion.PointValue;
        }

        public void RunQuiz()
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].DisplayAnswerChoices();
                Questions[i].GetUsersAnswers();
                int pts = Questions[i].GetUsersAnswers();
                UpdateScore(pts);
            }
        }
        public void UpdateScore(int x)
        {
            Score += x;
        }

        public void GradeQuiz()
        {
            Console.WriteLine("Your score is: " + Score + "/" + Total);
        }
    }
}

