using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace QuizStudio
{
    public class Checkbox : Question
    {
        private List<string> PossibleAnswers { get; set; }  
        private List<int> CorrectAnswers { get; set; }
        public Checkbox(int pointValue, string questionText, List<string> possibleAnswers, List<int> correctAnswers) : base(questionText, pointValue)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
            PointValue = CorrectAnswers.Count;
        }

        public override void DisplayAnswerChoices()
        {
            for (int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine(PossibleAnswers[i]);
            }
        }

        public int CheckUserAnswer(List<int> check)
        {
            int answersCorrect = 0;
            for (int i = 0; i < check.Count; i++)
            {
                if (CorrectAnswers.Contains(check[i]))
                {
                    answersCorrect++;
                }
            }
            return answersCorrect;
        }

        public override int GetUsersAnswers()
        {
            List<int> usersAnswers = new List<int>();
            Console.WriteLine("There may be more than one correct answer for these questions. To begin, please type 'GO'.");
            string continueOn = Console.ReadLine();
           
            while (continueOn.IndexOf("GO") >= 0 && usersAnswers.Count <= PossibleAnswers.Count)
            {
                Console.WriteLine("Enter the corresponding number of the answer you want. For example, to select the first option, enter 1.");
                string answer = Console.ReadLine();
                int option = int.Parse(answer);
                usersAnswers.Add(option);

                Console.WriteLine("There may be more than one correct answer here. To continue with this question, type 'GO'. To stop, type 'STOP'.");
                continueOn = Console.ReadLine();
            }
        return CheckUserAnswer(usersAnswers);
        }  
    }
}

