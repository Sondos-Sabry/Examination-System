using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class MCQ : Question
    {
      public override string Header => "MCQ Question";
      public MCQ()
        {
             Answers = new Answer[3];
        }
     

       public override void AddQuestion()
        {
            int mark, RightAnswer;
           
            Console.WriteLine(Header);

            //body of question

            Console.WriteLine("Please Enter The Body Of Question:");
            Body = Console.ReadLine();

            //marks of Question

            do
            {
                Console.WriteLine("Please Enter The Mark Of Question:");
            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

            Mark = mark;

            //Choices of Question
           
            Console.WriteLine("The Choise Of Question :");
            for (int i = 0; i < 3; i++)
            {
                Answers[i] = new Answer
                {
                    AnswerId = i + 1
                };
                Console.Write($"Please Enter The Choise Of Question Number {i+1}:\n ({i+1}) ");
                Answers[i].AnswerText = Console.ReadLine();
            }


            // right answer
            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Of Question (1 or 2 or 3):");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId < 1 || RightAnswerId > 3);

            CorrectAnswer.AnswerId = RightAnswerId;
            CorrectAnswer.AnswerText = Answers[RightAnswerId - 1].AnswerText;

            Console.Clear();


        }
    }
}
