using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class PracticalExam : Exam
    {
        public Question[] Questions { get; set; }
        public Answer[] Answers { get; set; }

        public PracticalExam() { }
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }
        public override void CreateListOfQuestions()
        {
            Questions = new MCQ[NumberOfQuestions];
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = new MCQ();
                Questions[i].AddQuestion();
                Console.Clear();
            }
        }

        public override void ShowExam()
        {
            
            int UserAnswer, TotalMark = 0, Grade = 0;

            foreach (var Question in Questions)
            {
                Console.WriteLine(Question);
                for (int i = 0; i < Question.Answers.Length; i++)
                {
                    Console.WriteLine(Question.Answers[i]);
                }
                Console.WriteLine("---------------------------");
              
                do
                {
                    Console.WriteLine("Please Enter Number Of Your Answer  :");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswer) || UserAnswer < 1 || UserAnswer > 3);

                Question.UserAnswer.AnswerId = UserAnswer;
                Question.UserAnswer.AnswerText = Question.Answers[UserAnswer - 1].AnswerText;
                Console.WriteLine("----------------------------------");
              
                
                Console.Clear();
                TotalMark += Question.Mark;

            }


            for (int i = 0; i < Questions.Length; i++)
            {
                
                if (Questions[i].CorrectAnswer.AnswerId == Questions[i].UserAnswer.AnswerId)
                {
                    Grade += Questions[i].Mark;
                }
                Console.WriteLine($"Question({i + 1}) :{Questions[i].Body}");
                Console.WriteLine($"Your Answer is : {Questions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"The Correct Answer is : {Questions[i].CorrectAnswer.AnswerText}");

            }
            Console.WriteLine($"Your Grade is {Grade}/{TotalMark}");






        }


    }


}
