namespace SortStudentsInDescendingOrder
{
    using System;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string secondName;

        public Student(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { firstName = value; }
        }
        public string SecondName
        {
            get { return this.secondName; }
            set { secondName = value; }
        }
    }
}