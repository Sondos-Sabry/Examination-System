using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class TrueOrFalse : Question
    {
        public override string Header => "True or False question";

        public TrueOrFalse()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");

        }
        public override void AddQuestion()
        {
            int mark, RightAnswer;

            Console.WriteLine("True Or False Question :");

            Console.WriteLine("Please Enter The Body Of Question:");
            Body = Console.ReadLine();


            //marks
            do
            {
                Console.WriteLine("Please Enter The Mark Of Question:");

            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);
            Mark = mark;

            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Of Question (1 for True and 2 for False ):");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId < 1 || RightAnswerId > 2);

            CorrectAnswer.AnswerId = RightAnswerId;
            CorrectAnswer.AnswerText = Answers[RightAnswerId - 1].AnswerText;


            Console.Clear();
        }

      
    }
}