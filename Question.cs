using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer CorrectAnswer { get; set; }
        public Answer UserAnswer { get; set; }
        public Question()
        {
            CorrectAnswer = new Answer();
            UserAnswer = new Answer();
        }


        public override string ToString()
        {
            return $"{Body}\t \t Mark: {Mark}";
        }

        public abstract void AddQuestion();

       
    }
}