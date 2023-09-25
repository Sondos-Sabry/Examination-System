using Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
    class FinalExam : Exam
    {
        public Question[] Questions { get; set; }
        public int Grade { get; set; }
        public Answer[] Answers { get; set; }
        public FinalExam() { }
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            int TypeOfQuestion;
            Questions = new Question[NumberOfQuestions];

            for (int i = 0; i < Questions.Length; i++)
            {
                do
                {
                    Console.Write($"Please Choose The Type Of Question Number ({i + 1})  ( 1 for MCQ || 2 for True Or False ):");
                } while (!int.TryParse(Console.ReadLine(), out TypeOfQuestion) || TypeOfQuestion < 1 || TypeOfQuestion > 2);
               
                Console.Clear();


                if (TypeOfQuestion == 1)
                {
                    Questions[i] = new MCQ();
                    Questions[i].AddQuestion();
                }
                else if (TypeOfQuestion == 2)
                {
                    Questions[i] = new TrueOrFalse();
                    Questions[i].AddQuestion();
                }
            }
        }
        public override void ShowExam()
        {
            int UserAnswer, TotalMark = 0, Grade = 0;
            foreach (var Question in Questions)
            {

                Console.WriteLine(Question);

                //Choices of question

                for (int i = 0; i < Question.Answers.Length; i++)
                {
                    Console.WriteLine(Question.Answers[i]);
                }
                Console.WriteLine("---------------------------");


                // Answer from User


                if (Question.Header == "MCQ Question")
                {


                    do
                    {
                        Console.WriteLine("Enter number of your answer:");

                    }
                    while ((!int.TryParse(Console.ReadLine(), out UserAnswer)) || (UserAnswer < 1 || UserAnswer > 3));

                    Question.UserAnswer.AnswerId = UserAnswer;
                    Question.UserAnswer.AnswerText = Question.Answers[UserAnswer - 1].AnswerText;
               
                    Console.WriteLine("-----------------");
                }
                     else if (Question.Header == "True or False question")
                    {


                        do
                        {
                            Console.WriteLine("Enter number of your answer:");

                        }
                        while ((!int.TryParse(Console.ReadLine(), out UserAnswer)) || (UserAnswer < 1 || UserAnswer > 2));

                        Question.UserAnswer.AnswerId = UserAnswer;
                        Question.UserAnswer.AnswerText = Question.Answers[UserAnswer - 1].AnswerText;
                        Console.WriteLine("-----------------");


                    }


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

