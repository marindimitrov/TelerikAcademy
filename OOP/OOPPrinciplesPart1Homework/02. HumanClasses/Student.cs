using System;
using System.Linq;

namespace HumanClasses
{
    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        public Student()
        {

        }
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
    }
}