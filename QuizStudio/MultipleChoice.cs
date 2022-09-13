using System;
namespace QuizStudio
{
    public class MultipleChoice : Question
    {
        public List<string> PossibleAnswers { get; set; }
        public int CorrectAnswer { get; set; }

        public MultipleChoice(string questionText, List<string> possibleAnswers, int correctAnswer, int points) : base(questionText, points)
        {
            CorrectAnswer = correctAnswer;
            PossibleAnswers = possibleAnswers;
            Points = 1;
        }

        public override void DisplayAnswerChoices()
        {
            foreach (string answer in PossibleAnswers)
            {
                Console.WriteLine(answer);
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
            Console.WriteLine("Please enter the correct answer's corresponding number: ");
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

