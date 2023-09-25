using System.Diagnostics;

namespace Exam
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject(1,"C#");
            sub1.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start The Exam ( y | n) :");
           
            char c = char.Parse(Console.ReadLine());
 Console.Clear();
            if (c == 'Y' || c == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                 sub1.Exam.ShowExam();
                Console.WriteLine($"Taken Time is : {sw.Elapsed}" );
            }
            else
                Console.WriteLine("Thank you!");
            

    }
    }
}