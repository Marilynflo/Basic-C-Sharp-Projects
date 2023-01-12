using System;

namespace MethodsandObjects
{
    class Program
    {
        static void Main(string[] args) 
        {
            Employee name = new Employee { FirstName = "Sample", LastName = "Student" }; //instantantiate and initialize an object with values
            name.SayName(); //using superclass method SayName
            Console.ReadLine();

        }
    }
}
