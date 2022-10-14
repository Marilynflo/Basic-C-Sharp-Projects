using System;

namespace DailyReportAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you in?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pagNum = Convert.ToInt32(pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool isAnswer = true;
            string answerStatus = Convert.ToString(isAnswer);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("Your positive experiences are: " + yourExperience);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("Your feedback is: " + yourFeedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int hourStudy = Convert.ToInt32(hoursStudy);
            Console.WriteLine("You studied " + hoursStudy + " hours today.");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}



            
            






    

