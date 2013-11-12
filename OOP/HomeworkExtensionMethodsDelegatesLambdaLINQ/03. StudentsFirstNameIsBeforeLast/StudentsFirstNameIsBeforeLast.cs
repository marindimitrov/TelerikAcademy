namespace LINQueryOperators
{
    using System;
    using System.Linq;

    //Write a method that from a given array of students finds all students whose 
    //first name is before its last name alphabetically. Use LINQ query operators.

    public class StudentsFirstNameIsBeforeLast
    {
        static void Main()
        {
            string[] students = new string[] { "Ivan Peshev", "Mitko Ivanov", "Pesho Georgiev", "Georgi Petkov" };

            var searchedStudents =
                from student in students
                where student[0] < student[student.IndexOf(' ') + 1]
                select student;

            foreach (var item in searchedStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}