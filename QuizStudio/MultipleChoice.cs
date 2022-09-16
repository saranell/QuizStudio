using System;
namespace QuizStudio
{
    public class MultipleChoice : Question
    {
        public List<string> PossibleAnswers { get; set; }
        public int CorrectAnswer { get; set; }

        public MultipleChoice(string questionText, List<string> possibleAnswers, int correctAnswer, int pointValue) : base(questionText, pointValue)
        {
            CorrectAnswer = correctAnswer;
            PossibleAnswers = possibleAnswers;
            PointValue = 1;
        }

        public override void DisplayAnswerChoices()
        {
            for (int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine(PossibleAnswers[i]);
            }
        }

        public bool CheckUserAnswer(int userAnswer)
        {
            if (userAnswer == CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetUsersAnswers()
        {
            Console.WriteLine("Please enter the correct answer's corresponding number. For example, to select the first option, enter 1.\n");
            string userAnswer = Console.ReadLine();
            int userAnswerNumber = int.Parse(userAnswer);

            if (CheckUserAnswer(userAnswerNumber) == true)
            {
                Console.WriteLine("That is correct!");
                return 1;
            }
            else
            {
                Console.WriteLine("Sorry, that is incorrect.");
                return 0;
            }
        }

         
    }
}

