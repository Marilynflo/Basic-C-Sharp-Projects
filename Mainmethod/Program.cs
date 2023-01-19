using System;

namespace Mainmethod
{
    class Program
    {



        static void Main(string[] args)
        {
            Operator operatorObject = new Operator(); // instantiating the operator class
            Console.WriteLine("Pick a number:");

            int result = 0;

            int userAns;
            if (int.TryParse(Console.ReadLine(), out userAns)) // parsing user input
            {
                Console.WriteLine("Pick another number--optional");
                string userAns2 = Console.ReadLine(); 
                if (userAns2 == null) // determining if user input is null
                {
                    result = operatorObject.Add(userAns); //calling the method
                }
                else
                {
                    result = operatorObject.Add(userAns);
                }
            }
            else
                {
                    Main(null);
                }


                Console.WriteLine("Passing result as an integer"); 
                Console.WriteLine(result);
                
                Console.ReadLine();
        }
    }
}
