using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{

    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Question { get; set; }


        public Exam() { }
        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;

        }

        public abstract void ShowExam();

        public abstract void CreateListOfQuestions();

    }

}
