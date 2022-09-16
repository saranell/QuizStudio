using System;

namespace QuizStudio

{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz firstQuiz = new Quiz(new List<Question>());

            List<string> testAnswers = new List<string>() { "yellow", "green", "blue", "purple" };
            MultipleChoice testQuestion = new MultipleChoice("What color is corn?", testAnswers, 1, 1);
            MultipleChoice sillyTestQuestion = new MultipleChoice("What color is the sky?", testAnswers, 3, 1);



            TrueFalse tfQuestion = new TrueFalse(1, "All dogs go to heaven", true);

            firstQuiz.AddQuestion(testQuestion);
            firstQuiz.AddQuestion(sillyTestQuestion);

            firstQuiz.RunQuiz();
            //testQuestion.DisplayAnswerChoices();
            //testQuestion.GetUsersAnswers();
        }
    } 
}