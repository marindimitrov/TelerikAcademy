namespace LINQueryOperators
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    class StudentsNamesBetween18and24
    {
        static void Main()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Ivan Ivanov", 15);
            students.Add("Gosho Georgiev", 18);
            students.Add("Pesho Petrov", 25);
            students.Add("Gencho Genchev", 20);
            students.Add("Rado Radostinov", 23);

            var searchedStudents =
                from student in students
                where student.Value > 18 && student.Value < 24
                select student;

            foreach (var student in searchedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}