using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanClasses
{
    class ProgramUI
    {
        public static void Main()
        {
            // List of 10 students
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivancho", "Ivanov", 2));
            students.Add(new Student("Ivancho", "Georgiev", 3));
            students.Add(new Student("Ivancho", "Petrov", 4));
            students.Add(new Student("Gosho", "Ivanov", 5));
            students.Add(new Student("Gosho", "Georgiev", 3));
            students.Add(new Student("Gosho", "Petrov", 2));
            students.Add(new Student("Peshko", "Ivanov", 2));
            students.Add(new Student("Peshko", "Georgiev", 1));
            students.Add(new Student("Peshko", "Petrov", 5));
            students.Add(new Student("Peshko", "Peshev", 4));

            IEnumerable<Student> sortedStudents = students.OrderBy(student => student.Grade);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", student.FirstName, student.LastName, student.Grade);
            }
            Console.WriteLine();

            // List of 10 workers
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Ivanov", 20));
            workers.Add(new Worker("Ivan", "Georgiev", 30));
            workers.Add(new Worker("Ivan", "Petrov", 40));
            workers.Add(new Worker("Georgi", "Ivanov", 50));
            workers.Add(new Worker("Georgi", "Georgiev", 30));
            workers.Add(new Worker("Georgi", "Petrov", 20));
            workers.Add(new Worker("Pesho", "Ivanov", 20));
            workers.Add(new Worker("Pesho", "Georgiev", 10));
            workers.Add(new Worker("Pesho", "Petrov", 50));
            workers.Add(new Worker("Pesho", "Peshev", 40));

            IEnumerable<Worker> sortedWorkers = workers.OrderByDescending(worker => worker.EarnedMoneyPerHour);

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", worker.FirstName, worker.LastName, worker.EarnedMoneyPerHour);
            }
            Console.WriteLine();

            // Merge two lists
            List<Human> mergedList = students.Concat<Human>(workers).ToList();

            // Order merged list
            var orderedMergedList =
                from human in mergedList
                orderby human.LastName
                orderby human.FirstName
                select human;

            foreach (var human in orderedMergedList)
            {
                Console.WriteLine("{0,-10} {1,-10}", human.FirstName, human.LastName);
            }
        }
    }
}