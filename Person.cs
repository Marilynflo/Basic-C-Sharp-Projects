using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsandObjects
{
    class Person // creating a class with data type properties with values
    {
        public string FirstName;
        public string LastName;

        public void SayName() //using the void method 
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
       

