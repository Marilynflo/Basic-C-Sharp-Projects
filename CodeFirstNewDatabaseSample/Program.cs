using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;



public class Program
{
    public static void Main(object FiddleHelper)
    {
        using (var ctx = new SchoolContext())
        {
            var stud = new Student() { StudentName = "Bill" };

            ctx.Students.Add(stud);
            ctx.SaveChanges();

            Console.Write("Student saved successfully!");

            // The following displays Student table data - dotnetfiddle.net specific code
            //FiddleHelper.WriteTable("Student", ctx.Students.ToList());
        }
    }
}

