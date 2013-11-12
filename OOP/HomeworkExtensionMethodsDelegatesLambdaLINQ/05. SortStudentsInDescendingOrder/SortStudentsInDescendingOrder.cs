namespace SortStudentsInDescendingOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the 
    //students by first name and last name in descending order. Rewrite the same with LINQ.

    class SortStudentsInDescendingOrder
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Petrov"));
            students.Add(new Student("Petar", "Ivanov"));
            students.Add(new Student("Georgi", "Ivanov"));
            students.Add(new Student("Ivan", "Georgiev"));

            // Sort by Lambda expression
            IEnumerable<Student> orderedStudents = 
                students.OrderBy(f => f.FirstName).ThenBy(f => f.SecondName);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }

            // Sort by LINQ
            var orderedStudentsByLinq =
                from student in students
                orderby student.SecondName
                orderby student.FirstName
                select student;

            foreach (var student in orderedStudentsByLinq)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }
        }
    }
}